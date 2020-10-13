using Mercado.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mercado.Infra.Context
{
    public class FoodContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public FoodContext(DbContextOptions<FoodContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Food> Foods { get; set; }

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
