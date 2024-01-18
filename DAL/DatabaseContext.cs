using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FarmaMundo.DAL
{

    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasIndex(c => c.Idproduct).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.ID).IsUnique();



            modelBuilder.Entity<Product>()
            .HasMany(p => p.CategoriesRelationList)
            .WithMany(p => p.ProductsRelationList)
            .UsingEntity<ProductCategory>(
                j => j
                .HasOne(p => p.category)
                .WithMany(p => p.ProductCategoriesRelationList)
                .HasForeignKey(p => p.CategoryId),
                j => j
                .HasOne(P => P.product)
                .WithMany(p => p.ProductCategoriesRelationList)
                .HasForeignKey(p => p.ProductId),
                j =>
                {
                    j.HasKey(t => new { t.ProductId, t.CategoryId });
                }
                );

        }
    }
}
