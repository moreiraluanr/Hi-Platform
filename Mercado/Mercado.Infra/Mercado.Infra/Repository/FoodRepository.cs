using Mercado.Domain.Entities;
using Mercado.Domain.Repository.Abstract;
using Mercado.Infra.Context;
using System;

namespace Mercado.Domain.Repository
{
    public class FoodRepository : MarketRepository<Food, int>, IFoodRepository, IDisposable
    {
        public FoodRepository(FoodContext context) : base(context)
        {

        }
    }
}
