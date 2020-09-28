using Microsoft.EntityFrameworkCore;
using N_tier.Core.Models;

namespace N_tier.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
