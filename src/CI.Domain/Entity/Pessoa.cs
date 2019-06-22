using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Domain.Entity
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
