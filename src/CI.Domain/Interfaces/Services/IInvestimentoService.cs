using CI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CI.Domain.Interfaces.Services
{
    public interface IInvestimentoService
    {
        Investimento Adicionar(Investimento entity);
        void Atualizar(Investimento entity);
        IEnumerable<Investimento> ObterTodos();
        Investimento ObterPorId(int id);
        IEnumerable<Investimento> Buscar(Expression<Func<Investimento, bool>> predicado);
        void Remover(Investimento entity);
    }
}
