using Microsoft.EntityFrameworkCore;

namespace FarmaMundo.DAL
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasIndex(c => c.Idproduct).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.ID).IsUnique();
           
        }
    }
}
