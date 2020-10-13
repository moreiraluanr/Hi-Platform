namespace Mercado.Aplicattion.Model
{
    public class ListElementStockResponse
    {
        public int Id { get; set; }
        public decimal Price { get; private set; }
        public string CnpjManufacturer { get; private set; }
        public decimal Cost { get; private set; }
    }
}
