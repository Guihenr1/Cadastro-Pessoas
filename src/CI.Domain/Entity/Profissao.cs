using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Domain.Entity
{
    public class Profissao
    {
        public Profissao()
        {

        }

        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public ICollection<UsuarioProfissao> UsuarioProfissoes { get; set; }
    }
}
