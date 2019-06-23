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
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Investimento>().ToTable("Investimento");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");

            #region Configurações do usuário

            modelBuilder.Entity<Usuario>()
                .HasKey(e => e.UsuarioId);
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Investimentos)
                .WithOne(u => u.Usuario)
                .HasForeignKey(u => u.UsuarioId)
                .HasPrincipalKey(u => u.UsuarioId);
            modelBuilder.Entity<Usuario>().Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            #endregion

            #region Configurações do investimento

            modelBuilder.Entity<Investimento>()
                .HasKey(e => e.InvestimentoId);
            modelBuilder.Entity<Investimento>()
                .HasOne(e => e.Usuario)
                .WithMany(e => e.Investimentos)
                .HasForeignKey(e => e.UsuarioId)
                .HasPrincipalKey(e => e.UsuarioId);
            modelBuilder.Entity<Investimento>().Property(e => e.Tipo)
                .HasColumnType("varchar(20)")
                .IsRequired();

            modelBuilder.Entity<Investimento>().Property(e => e.Valor)
                .HasColumnType("decimal(5,2)")
                .IsRequired();

            #endregion

            #region Configurações da Profissão

            modelBuilder.Entity<Profissao>().Property(p => p.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            #endregion

            #region Configuração Menu

            modelBuilder.Entity<Menu>()
                .HasMany(x => x.SubMenu)
                .WithOne()
                .HasForeignKey(x => x.MenuId);

            #endregion
        }
    }
}
