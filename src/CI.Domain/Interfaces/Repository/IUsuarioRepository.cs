using CI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ObterPorInvestimento(int usuarioId);
    }
}
