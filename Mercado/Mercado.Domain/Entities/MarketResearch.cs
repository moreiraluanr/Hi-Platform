namespace Mercado.Domain.Entities
{
    public class MarketResearch : Entity<int>
    {
        public MarketResearch()
        {

        }

        public MarketResearch(int satisfaction, string researchInstitute, int idCleaningProduct)
        {
            Satisfaction = satisfaction;
            ResearchInstitute = researchInstitute;
            IdCleaningProduct = idCleaningProduct;
        }

        public int Satisfaction { get; private set; }
        public string ResearchInstitute { get; private set; }
        public int IdCleaningProduct { get; private set; }
    }
}
