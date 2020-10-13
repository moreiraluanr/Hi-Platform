namespace Mercado.Aplicattion.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InsertElementStockRequest
    {
        public decimal Price { get; set; }
        public string CnpjManufacturer { get; set; }
        public decimal Cost { get; set; }
    }
}
