using CI.Domain.Entity;
using CI.Infrastructure.EntityConfig;
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
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new InvestimentoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoMap());
            modelBuilder.ApplyConfiguration(new MenuMap());
        }
    }
}
