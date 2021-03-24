namespace FurnitureTradeDemo.Models
{
    public interface IDiscount
    {
        public decimal CalculatePrice(BasketItem basketItem);
    }
}