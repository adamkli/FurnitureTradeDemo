using FurnitureTradeDemo.Models;
using System;

namespace FurnitureTradeDemo.Services
{
    public static class DiscountFactory
    {
        public static IDiscount Create(int discountAgreementId)
        {
            switch ((DiscountType)discountAgreementId)
            {
                case DiscountType.NoDiscount:
                    return new DiscountService();
                case DiscountType.Discount80Percent:
                    return new DiscountService(0.8m);
                case DiscountType.VolumeDiscount:
                    return new VolumeDiscountService();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
