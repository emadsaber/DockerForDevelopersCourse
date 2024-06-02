using Microsoft.EntityFrameworkCore;
using MyStore.Entities;
using MyStore.Enums;

namespace MyStore.Data
{
    public class MyStoreDbContext : DbContext,IMyStoreDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MyStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(mb =>
            {
                mb.HasKey(x => x.Id);
                mb.Property(x => x.Name).HasMaxLength(200);
                mb.Property(x => x.Description).HasMaxLength(500);
                mb.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId).IsRequired();
            });

            modelBuilder.Entity<Category>(mb =>
            {
                mb.HasKey(x => x.Id);
                mb.Property(x => x.Name).HasMaxLength(200);
                mb.Property(x => x.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<Category>().HasData(new List<Category> {
                new Category(1, "Food", "All food items"),
                new Category(2, "Detergents", "Items relating to cleaning glass and floors"),
                new Category(3, "Drinks", "Syrups and liquid items packed in bottles"),
            });

            modelBuilder.Entity<Product>().HasData(new List<Product> {
                new Product(1, "Potatoes", "Fresh Potatoes", 40, 5000, CategoriesEnum.Food.GetHashCode()),
                new Product(2, "Harpic", "Cleaning toilets", 20, 1000, CategoriesEnum.Detergents.GetHashCode()),
                new Product(3, "Orange Juice", "Fresh Juice", 15, 200, CategoriesEnum.Drinks.GetHashCode()),
            });
        }
    }
}
