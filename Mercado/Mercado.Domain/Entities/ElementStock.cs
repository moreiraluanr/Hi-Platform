namespace Mercado.Domain.Entities
{
    public class ElementStock : Entity<int>
    {
        public ElementStock()
        {

        }

        public ElementStock(decimal price, string cnpjManufacturer, decimal Cost)
        {
            Price = price;
            CnpjManufacturer = cnpjManufacturer;
            this.Cost = Cost;
        }

        public decimal Price { get; private set; }
        public string CnpjManufacturer { get; private set; }
        public decimal Cost { get; private set; }
    }
}
