namespace FurnitureTradeDemo.Models
{
    public class Discount : DiscountBase
    {
        private readonly decimal factor;

        public Discount(decimal factor = 1)
        {
            this.factor = factor;
        }

        public override decimal GetFactor(BasketItem basketItem)
        {
            return factor;
        }
    }
}
