using FurnitureTradeDemo.Data;
using FurnitureTradeDemo.Models;

namespace FurnitureTradeDemo.Services
{
    public static class CustomerService
    {
        public static IDiscount  GetDiscount(Customer customer) => DiscountFactory.Create(customer.DiscountAgreementId);
    }
}
