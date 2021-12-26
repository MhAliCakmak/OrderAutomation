using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Abstract
{
    public interface ICustomerChooseServices
    {
        void Add(CustomerChoose customerChoose);
        void Delete(CustomerChoose customerChoose);
        void Update(CustomerChoose customerChoose);
        List<CustomerChoose> GetAll();
    }
}
