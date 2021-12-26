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
    public class CustomerChooseManager : ICustomerChooseServices
    {
        private ICustomerChooseDal _customerChoooseDal;

        public CustomerChooseManager(ICustomerChooseDal customerChoooseDal)
        {
            _customerChoooseDal = customerChoooseDal;
        }

        public void Add(CustomerChoose customerChoose)
        {
            _customerChoooseDal.Add(customerChoose);
        }

        public void Delete(CustomerChoose customerChoose)
        {
            _customerChoooseDal.Delete(customerChoose);
        }

        public List<CustomerChoose> GetAll()
        {
            return _customerChoooseDal.GetAll();
        }

        public void Update(CustomerChoose customerChoose)
        {
            _customerChoooseDal.Update(customerChoose);
        }
    }
}
