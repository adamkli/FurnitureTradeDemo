using NUnit.Framework;
using FurnitureTradeDemo.Models;
using FurnitureTradeDemo.Data;

namespace FurnitureTradeDemoTests
{
    [TestFixture()]
    public class GivenCustomerWithBasketItem
    {
        [TestCase(1, 1)]
        [TestCase(10, 9.5)]
        [TestCase(10000, 8000)]
        public void GetPriceForQuantity_Returns(int quantity, decimal discountedPrice)
        {
            var customer = new Customer { Name = "Volume Discount Customer", DiscountAgreementId = DiscountType.VolumeDiscount };
            var product = new Product { Name = "Chair", StandardPrice = 1 };
            var basketItem = new BasketItem { Product = product, Quantity = quantity };

            IDiscount discount = customer.GetDiscount();
            var price = discount.CalculatePrice(basketItem);
            Assert.That(price, Is.EqualTo(discountedPrice));

        }
    }
}