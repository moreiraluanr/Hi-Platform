﻿namespace Mercado.Aplicattion.Model
{
    public class AlterMarketResearchRequest
    {
        public int Id { get; set; }
        public int Satisfaction { get; set; }
        public string ResearchInstitute { get; set; }
        public int IdCleaningProduct { get; set; }
    }
}
