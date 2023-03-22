using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AzureSqlLab5.Models
{

    namespace AzureSqlLab5
    {
        public class ProductCategoryDbContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>().ToContainer("Products");
                modelBuilder.Entity<Category>().ToContainer("Categories");
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseCosmos(
                "AccountEndpoint=https://nosqldbyehor.documents.azure.com:443/;" +
                "AccountKey=KNa69NL3IiQFc2VoA5uoimquNrLab8jyZ6O3kmjEcrZir8obicEXSREQnRd0xA5IgHh1" +
                "jGqoWGCkACDbExgvIQ==;", "ProductCategoryDb");
            }
        }
    }
}
