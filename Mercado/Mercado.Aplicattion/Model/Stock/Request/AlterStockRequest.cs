namespace Mercado.Aplicattion.Model.Stock.Request
{
    public class AlterStockRequest
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int IdElementStock { get; set; }
    }
}
