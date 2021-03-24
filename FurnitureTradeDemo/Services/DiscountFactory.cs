using FurnitureTradeDemo.Data;
using FurnitureTradeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureTradeDemo.Services
{

    public static class DiscountFactory
    {
        public static IDiscount Create(DiscountType discountAgreementId)
        {
            switch (discountAgreementId)
            {
                case DiscountType.NoDiscount:
                    return new Discount();
                case DiscountType.Discount80Percent:
                    return new Discount(0.8m);
                case DiscountType.VolumeDiscount:
                    return new VolumeDiscount();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
