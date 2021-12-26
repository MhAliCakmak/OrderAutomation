using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderAutomation.Entities.Concrete
{
    public class Credit : Payment
    {
        public int CreditId { get; set; }
        public string Number{ get; set; }
        public string Type { get; set; }
        public string ExpData { get; set; }
        public override decimal Amount { get; set; }
    }
}
