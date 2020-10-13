namespace Mercado.Domain.Entities
{
    public class Stock : Entity<int>
    {
        public Stock()
        {

        }

        public Stock(int amount, int idElementStock)
        {
            Amount = amount;
            IdElementStock = idElementStock;
        }

        public int Amount { get; private set; }
        public int IdElementStock { get; private set; }
    }
}
