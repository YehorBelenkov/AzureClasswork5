using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureClasswork5.Class
{
    public class AzureDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToContainer("Books");
            modelBuilder.Entity<Author>().ToContainer("Authors");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string is all one but just cutted it to make some space
            optionsBuilder.UseCosmos(
                "AccountEndpoint=link" +
                "AccountKey=yourkey","namethisdb");
        }
    }
}
