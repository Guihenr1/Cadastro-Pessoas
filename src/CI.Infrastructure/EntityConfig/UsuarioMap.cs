using CI.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Infrastructure.EntityConfig
{
    class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.UsuarioId);
            builder
                .HasMany(u => u.Investimentos)
                .WithOne(u => u.Usuario)
                .HasForeignKey(u => u.UsuarioId)
                .HasPrincipalKey(u => u.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();
        }
    }
}
