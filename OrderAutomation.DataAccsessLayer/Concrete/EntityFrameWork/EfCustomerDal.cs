using OrderAutomation.DataAccsessLayer.Abstract;
using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.DataAccsessLayer.Concrete.EntityFrameWork
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, OrderAutomationContext>, ICustomerDal
    {
    }
}
