using CI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CI.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ControleInvestimentosContext context)
        {
            if (context.Usuarios.Any())
                return;

            var usuarios = new Usuario[]
            {
                new Usuario{Nome = "Guilherme", CPF = "09768255030"},
                new Usuario{Nome = "Henrique", CPF = "84302871083"}
            };

            context.AddRange(usuarios);

            var investimentos = new Investimento[]
            {
                new Investimento{Tipo = "Ações", Valor = "5.000", Usuario = usuarios[0]},
                new Investimento{Valor = "10.000", Usuario = usuarios[0]}
            };

            context.AddRange(investimentos);

            context.SaveChanges();
        }
    }
}
