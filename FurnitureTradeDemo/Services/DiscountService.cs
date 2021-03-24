using FurnitureTradeDemo.Models;

namespace FurnitureTradeDemo.Services
{
    public class DiscountService : DiscountServiceBase
    {
        private readonly decimal factor;

        public DiscountService(decimal factor = 1)
        {
            this.factor = factor;
        }

        public override decimal GetFactor(BasketItem basketItem)
        {
            return factor;
        }
    }
}
