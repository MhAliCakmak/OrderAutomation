using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Concrete
{
    public class Item
    {
        public int ItemId { get; set; }
        public double ShippingWeight { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ItemName { get; set; }
        

    }
}
