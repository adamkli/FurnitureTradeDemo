using FurnitureTradeDemo.Models;

namespace FurnitureTradeDemo.Services
{
    public abstract class DiscountServiceBase : IDiscount
    {
        public virtual decimal GetFactor(BasketItem basketItem)
        {
            return 1;
        }
        public virtual decimal CalculatePrice(BasketItem basketItem)
        {
            return GetFactor(basketItem) * basketItem.Product.StandardPrice * basketItem.Quantity;
        }
    }
}
