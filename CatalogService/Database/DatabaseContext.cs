using Microsoft.EntityFrameworkCore;

namespace CatalogService.Database
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) { 
        
        }
        public DbSet<Products> Products { get; set; }
    }
}
