using System;

namespace Mercado.Domain.Entities
{
    public class CleaningProduct : Entity<int>
    {
        public CleaningProduct()
        {

        }

        public CleaningProduct(DateTime expirationDate, decimal volume, int idElementStock, string name)
        {
            ExpirationDate = expirationDate;
            Volume = volume;
            IdElementStock = idElementStock;
            Name = name;
        }

        public DateTime ExpirationDate { get; private set; }
        public decimal Volume { get; private set; }
        public int IdElementStock { get; private set; }
        public string Name { get; private set; }
    }
}
