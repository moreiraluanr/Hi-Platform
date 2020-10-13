using System;

namespace Mercado.Domain.Entities
{
    public class Food : Entity<int>
    {
        public Food()
        {

        }

        public Food(DateTime expirationDate, string name, int idElementStock, decimal weight)
        {
            ExpirationDate = expirationDate;
            Name = name;
            IdElementStock = idElementStock;
            Weight = weight;
        }

        public DateTime ExpirationDate { get; private set; }
        public string Name { get; private set; }
        public int IdElementStock { get; private set; }
        public decimal Weight { get; private set; }
    }
}
