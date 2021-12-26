using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Concrete
{
    public class LogIn
    {
        public int ID { get; set; }
        public string EPosta { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}
