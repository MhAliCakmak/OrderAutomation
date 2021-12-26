using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderAutomation.Entities.Concrete
{
    public class Check : Payment
    {
        public int CheckId { get; set; }
        public string Name { get; set; }
        public string BankID { get; set; }
        public override decimal Amount { get; set; }

    }
}
