using CI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CI.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        Usuario Adicionar(Usuario entity);
        void Atualizar(Usuario entity);
        IEnumerable<Usuario> ObterTodos();
        Usuario ObterPorId(int id);
        IEnumerable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado);
        void Remover(Usuario entity);
    }
}
