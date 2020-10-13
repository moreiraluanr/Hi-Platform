using Mercado.Domain.Entities;
using Mercado.Domain.Repository.Abstract;
using Mercado.Infra.Context;
using System;

namespace Mercado.Domain.Repository
{
    public class StockRepository : MarketRepository<Stock, int>, IStockRepository, IDisposable
    {
        public StockRepository(StockContext context) : base(context)
        {

        }
    }
}
