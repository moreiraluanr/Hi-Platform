using Mercado.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mercado.Infra.Context
{
    public class MarketResearchContext :DbContext
    {
        private readonly IConfiguration _configuration;

        public MarketResearchContext(DbContextOptions<MarketResearchContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<MarketResearch> MarketResearches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(_configuration.GetConnectionString("SqlServer"));
            }
        }
    }
}
