using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Domain.Entities
{
    public class Kit
    {
        public Kit(string nameCleaningProduct, string nameFood, decimal price, decimal profit, DateTime expirationDate)
        {
            NameCleaningProduct = nameCleaningProduct;
            NameFood = nameFood;
            Price = price;
            Profit = profit;
            ExpirationDate = expirationDate;
        }

        public string NameCleaningProduct { get; private set; }
        public string NameFood { get; private set; }
        public decimal Price { get; private set; }
        public decimal Profit { get; private set; }
        public DateTime ExpirationDate { get; private set; }
    }
}
