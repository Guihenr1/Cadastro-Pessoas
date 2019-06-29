using CI.Domain.Entity;
using CI.Domain.Interfaces.Repository;
using CI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CI.Infrastructure.Repository
{
    public class InvestimentoRepository : EFRepository<Investimento>, IInvestimentoRepository
    {
        public InvestimentoRepository(ControleInvestimentosContext dbContext) : base(dbContext)
        {

        }
    }
}
