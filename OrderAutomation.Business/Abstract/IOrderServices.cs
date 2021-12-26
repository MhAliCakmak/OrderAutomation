using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Abstract
{
    public interface IOrderServices
    {
        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);
        List<Order> GetAll();
        int GetTax(decimal tbxprice, int quantity);
    }
}
