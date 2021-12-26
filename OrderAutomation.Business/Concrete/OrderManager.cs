using OrderAutomation.Business.Abstract;
using OrderAutomation.DataAccsessLayer.Abstract;
using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Concrete
{
    public class OrderManager : IOrderServices
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }
        public void Delete(Order order)
        {
            try
            {
                _orderDal.Delete(order);
            }
            catch (Exception)
            {    
                throw new Exception("Silme Gerçekleştirilemedi");
            }
        }
        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public int GetTax(decimal tbxprice, int quantity)
        {
            int tax = 0;
            tax = Convert.ToInt32(tbxprice * 18 / 100);

            return tax*quantity;
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
