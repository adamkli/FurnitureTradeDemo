using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureTradeDemo.Data
{
    public class DiscountAgreement:Entity
    {
        public int DiscountType { get; set; }
        public int Parameter1 { get; set; }
    }
}
