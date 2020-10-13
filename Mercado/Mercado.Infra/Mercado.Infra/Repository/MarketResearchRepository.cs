using Mercado.Domain.Entities;
using Mercado.Domain.Repository.Abstract;
using Mercado.Infra.Context;
using System;

namespace Mercado.Domain.Repository
{
    public class MarketResearchRespository : MarketRepository<MarketResearch, int>, IMarketResearchRepository, IDisposable
    {
        public MarketResearchRespository(MarketResearchContext context) : base(context)
        {

        }
    }
}
