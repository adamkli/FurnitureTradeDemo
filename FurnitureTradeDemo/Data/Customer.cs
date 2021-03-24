using FurnitureTradeDemo.Models;
using FurnitureTradeDemo.Services;

namespace FurnitureTradeDemo.Data
{
    public class Customer : Entity
    {
        public DiscountType DiscountAgreementId { get; set; }
        public IDiscount GetDiscount() => DiscountFactory.Create(DiscountAgreementId);
    }
}
