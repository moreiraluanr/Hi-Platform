using Mercado.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mercado.Infra.Context
{
    public class StockContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public StockContext(DbContextOptions<StockContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Stock> Stocks { get; set; }

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
