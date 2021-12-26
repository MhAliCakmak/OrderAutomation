using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
