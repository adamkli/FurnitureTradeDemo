using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                new Customer { Id = 1, Name = "No Discount Customer", DiscountAgreementId = DiscountType.NoDiscount },
                new Customer { Id = 2, Name = "Discount Customer", DiscountAgreementId = DiscountType.Discount80Percent },
                new Customer { Id = 3, Name = "Volume Discount Customer", DiscountAgreementId = DiscountType.VolumeDiscount }
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
