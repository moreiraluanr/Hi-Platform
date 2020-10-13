using System;

namespace Mercado.Aplicattion.Model
{
    public class ListKitResponse
    {
        public string NameCleaningProduct { get; set; }
        public string NameFood { get; set; }
        public decimal Price { get; set; }
        public decimal Profit { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
