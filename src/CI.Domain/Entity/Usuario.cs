using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Domain.Entity
{
    public class Usuario
    {
        public Usuario()
        {

        }

        public int usuarioId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public ICollection<Investimento> investimentos { get; set; }
    }
}
