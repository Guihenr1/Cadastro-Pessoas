using CI.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Infrastructure.EntityConfig
{
    class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
