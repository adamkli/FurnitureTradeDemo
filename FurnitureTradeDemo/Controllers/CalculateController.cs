using FurnitureTradeDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Linq;
using FurnitureTradeDemo.Data;
using FurnitureTradeDemo.Services;

namespace FurnitureTradeDemo.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public partial class CalculateController : ControllerBase
    {
        private readonly FurnitureTradeContext furnitureTradeContext;

        public CalculateController(FurnitureTradeContext furnitureTradeContext)
        {
            furnitureTradeContext.Database.EnsureCreated();
            this.furnitureTradeContext = furnitureTradeContext;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemDTO>> GetCustomers()
        {
            var customers = await furnitureTradeContext.Customers.ToListAsync();

            var result = customers
                .Select(el => new ItemDTO() {        
                    Id = el.Id, Name = $"{el.Name} [{el.DiscountAgreementId}]" 
                });

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemDTO>> GetProducts()
        {
            var furnitures = await furnitureTradeContext.Products.ToListAsync();

            var result = furnitures
                .Select(el => new ItemDTO() {
                    Id = el.Id, Name = $"{el.Name} [{el.StandardPrice}]"
                });

            return result;
        }
        [HttpPost]
        public async Task<ActionResult<object>> CalculatePrice([FromBody] CalculationParamsDTO calculationParams)
        {
            var customer = await furnitureTradeContext.Customers.FindAsync(calculationParams.CustomerId);
            var product = await furnitureTradeContext.Products.FindAsync(calculationParams.ProductId);

            BasketItem item = new BasketItem() { Product = product, Quantity = calculationParams.Quantity };

            var result = CustomerService.GetDiscount(customer).CalculatePrice(item);

            return result;
        }

    }
}
