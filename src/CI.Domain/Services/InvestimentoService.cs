using CI.Domain.Entity;
using CI.Domain.Interfaces.Repository;
using CI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CI.Domain.Services
{
    public class InvestimentoService : IInvestimentoService
    {
        private readonly IInvestimentoRepository _InvestimentoRepository;
        public InvestimentoService(IInvestimentoRepository InvestimentoRepository)
        {
            _InvestimentoRepository = InvestimentoRepository;
        }

        public Investimento Adicionar(Investimento entity)
        {
            //Regras específicas são colocadas aqui
            return _InvestimentoRepository.Adicionar(entity);
        }

        public void Atualizar(Investimento entity)
        {
            _InvestimentoRepository.Atualizar(entity);
        }

        public IEnumerable<Investimento> Buscar(Expression<Func<Investimento, bool>> predicado)
        {
            return _InvestimentoRepository.Buscar(predicado);
        }

        public Investimento ObterPorId(int id)
        {
            return _InvestimentoRepository.ObterPorId(id);
        }

        public IEnumerable<Investimento> ObterTodos()
        {
            return _InvestimentoRepository.ObterTodos();
        }

        public void Remover(Investimento entity)
        {
            _InvestimentoRepository.Remover(entity);
        }
    }
}
