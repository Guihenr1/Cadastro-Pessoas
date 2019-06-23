using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Domain.Entity
{
    public class UsuarioProfissao
    {
        public UsuarioProfissao()
        {

        }

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int ProfissaoId { get; set; }
        public Profissao Profissao { get; set; }
    }
}
