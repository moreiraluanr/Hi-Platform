using Mercado.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mercado.Infra.Context
{
    public class CleaningProductContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public CleaningProductContext(DbContextOptions<CleaningProductContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<CleaningProduct> CleaningProducts { get; set; }

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
