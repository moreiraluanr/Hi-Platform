using Mercado.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mercado.Infra.Context
{
    public class ElementStockContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ElementStockContext(DbContextOptions<ElementStockContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<ElementStock> ElementStocks { get; set; }

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
