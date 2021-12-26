using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Concrete
{
    public class CustomerChoose
    {
        
        public int ID { get; set; }
        public double CShippingWeight { get; set; }
        public string CDescription { get; set; }
        public decimal CPrice { get; set; }
        public string CItemName { get; set; }
        public string PayType { get; set; }
    }
}
