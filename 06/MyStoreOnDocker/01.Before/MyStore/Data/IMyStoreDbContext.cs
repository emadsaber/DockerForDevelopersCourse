using Microsoft.EntityFrameworkCore;
using MyStore.Entities;

namespace MyStore.Data
{
    public interface IMyStoreDbContext 
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
