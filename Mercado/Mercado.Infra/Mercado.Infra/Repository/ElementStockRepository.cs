using Mercado.Domain.Entities;
using Mercado.Domain.Repository.Abstract;
using Mercado.Infra.Context;
using System;

namespace Mercado.Domain.Repository
{
    public class ElementStockRepository : MarketRepository<ElementStock, int>, IElementStockRepository, IDisposable
    {
        public ElementStockRepository(ElementStockContext context) : base(context)
        {

        }
    }
}
