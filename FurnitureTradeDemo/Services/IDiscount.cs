using FurnitureTradeDemo.Models;

namespace FurnitureTradeDemo.Services
{
    public interface IDiscount
    {
        public decimal CalculatePrice(BasketItem basketItem);
    }
}