using Mercado.Domain.Entities;

namespace Mercado.Domain.Repository
{
    public interface IStockRepository : IMarket<Stock, int>
    {
    }
}
