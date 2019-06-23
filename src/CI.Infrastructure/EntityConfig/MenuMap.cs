using CI.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Infrastructure.EntityConfig
{
    class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder
                .HasMany(x => x.SubMenu)
                .WithOne()
                .HasForeignKey(x => x.MenuId);
        }
    }
}
