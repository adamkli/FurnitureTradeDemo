using FurnitureTradeDemo.Data;

namespace FurnitureTradeDemo.Models
{
    public abstract class DiscountBase : Entity, IDiscount
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
