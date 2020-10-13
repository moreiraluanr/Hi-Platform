using System;

namespace Mercado.Aplicattion.Model
{
    public class GetFoodResponse
    {
        public int Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Name { get; set; }
        public int IdElementStock { get; set; }
        public decimal Weight { get; set; }
    }
}
