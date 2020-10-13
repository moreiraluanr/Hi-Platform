using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Domain.Entities
{
    public class Kit
    {
        public string NameCleaningProduct { get; private set; }
        public string NameFood { get; private set; }
        public decimal Price { get; private set; }
        public decimal Profit { get; private set; }
        public DateTime ExpirationDate { get; private set; }
    }
}
