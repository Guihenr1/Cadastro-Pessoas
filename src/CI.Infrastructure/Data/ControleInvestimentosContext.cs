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

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
        }
    }
}
