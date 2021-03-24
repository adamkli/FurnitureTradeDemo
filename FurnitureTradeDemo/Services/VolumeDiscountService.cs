using FurnitureTradeDemo.Models;

namespace FurnitureTradeDemo.Services
{
    public class VolumeDiscountService : DiscountServiceBase
    {
        public override decimal GetFactor(BasketItem basketItem)
        {
            var discountFactor = basketItem.Quantity switch
            {
                var n when n >= 1000 => 0.8m,
                var n when n >= 100 => 0.9m,
                var n when n >= 10 => 0.95m,
                _ => 1
            };

            return discountFactor;
        }
    }
}