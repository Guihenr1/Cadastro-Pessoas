using CI.Domain.Entity;
using CI.Domain.Interfaces.Repository;
using CI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CI.Infrastructure.Repository
{
    public class UsuarioRepository : EFRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ControleInvestimentosContext dbContext) : base(dbContext)
        {

        }
        public Usuario ObterPorInvestimento(int usuarioId)
        {
            return Buscar(x => x.UsuarioProfissoes.Any(p => p.UsuarioId == usuarioId))
                .FirstOrDefault();
        }
    }
}
