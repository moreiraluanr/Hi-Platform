using Mercado.Domain.Entities;
using Mercado.Domain.Repository.Abstract;
using Mercado.Infra.Context;
using System;

namespace Mercado.Domain.Repository
{
    public class CleaningProductRepository : MarketRepository<CleaningProduct, int>, ICleaningProductRepository, IDisposable
    {
        public CleaningProductRepository(CleaningProductContext context) : base(context)
        {

        }
    }
}
