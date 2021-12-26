using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Concrete
{
    public class OrderDetail 
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public int taxStatus { get; set; }

    }
}
