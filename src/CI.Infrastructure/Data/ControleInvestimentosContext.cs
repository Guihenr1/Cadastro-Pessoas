using CI.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Infrastructure.Data
{
    public class ControleInvestimentosContext : DbContext
    {
        public ControleInvestimentosContext(DbContextOptions<ControleInvestimentosContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Investimento> Investimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Investimento>().ToTable("Investimentos");

            #region Configurações do usuário

            modelBuilder.Entity<Usuario>().Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            #endregion

            #region Configurações do investimento

            modelBuilder.Entity<Investimento>().Property(e => e.Tipo)
                .HasColumnType("varchar(20)");

            modelBuilder.Entity<Investimento>().Property(e => e.Valor)
                .HasColumnType("varchar(10)")
                .IsRequired();

            #endregion
        }
    }
}
