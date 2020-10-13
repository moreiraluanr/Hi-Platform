using System;

namespace Mercado.Aplicattion.Model
{
    public class ListCleaningProductResponse
    {
        public int Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Volume { get; set; }
        public int IdElementStock { get; set; }
        public string Name { get; set; }
    }
}
