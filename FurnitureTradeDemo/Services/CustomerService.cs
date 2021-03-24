using FurnitureTradeDemo.Data;
using System;

namespace FurnitureTradeDemo.Services
{
    public static class CustomerService
    {
        public static IDiscount GetDiscount(Customer customer) {

            return ((DiscountType)customer.DiscountAgreementId) switch
            {
                DiscountType.NoDiscount => new DiscountService(),
                DiscountType.Discount80Percent => new DiscountService(0.8m),
                DiscountType.VolumeDiscount => new VolumeDiscountService(),
                _ => throw new NotImplementedException(),
            };
        }

    }
}
