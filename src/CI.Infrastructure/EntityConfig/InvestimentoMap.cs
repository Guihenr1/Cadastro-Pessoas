using CI.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Infrastructure.EntityConfig
{
    class InvestimentoMap : IEntityTypeConfiguration<Investimento>
    {
        public void Configure(EntityTypeBuilder<Investimento> builder)
        {
            builder
                .HasKey(e => e.InvestimentoId);
            builder
                .HasOne(e => e.Usuario)
                .WithMany(e => e.Investimentos)
                .HasForeignKey(e => e.UsuarioId)
                .HasPrincipalKey(e => e.UsuarioId);
            builder.Property(e => e.Tipo)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(e => e.Valor)
                .HasColumnType("decimal(5,2)")
                .IsRequired();
        }
    }
}
