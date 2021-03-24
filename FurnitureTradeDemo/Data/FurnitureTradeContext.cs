using FurnitureTradeDemo.Services;
using Microsoft.EntityFrameworkCore;

namespace FurnitureTradeDemo.Data
{
    public class FurnitureTradeContext : DbContext
    {
        public FurnitureTradeContext(DbContextOptions<FurnitureTradeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "No Discount Customer", DiscountAgreementId = (int)DiscountType.NoDiscount },
                new Customer { Id = 2, Name = "Discount Customer", DiscountAgreementId = (int)DiscountType.Discount80Percent },
                new Customer { Id = 3, Name = "Volume Discount Customer", DiscountAgreementId = (int)DiscountType.VolumeDiscount }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Chair", StandardPrice = 1 },
                new Product { Id = 2, Name = "Table", StandardPrice = 3 }
                );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
