using System;

namespace Mercado.Aplicattion.Model
{
    public class InsertFoodRequest
    {
        public DateTime ExpirationDate { get; set; }
        public string Name { get; set; }
        public int IdElementStock { get; set; }
        public decimal Weight { get; set; }
    }
}
