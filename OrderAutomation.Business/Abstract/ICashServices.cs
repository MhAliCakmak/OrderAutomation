using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Abstract
{
    public interface ICashServices
    {
        void Add(Cash cash);
        void Delete(Cash cash);
        void Update(Cash cash);
        List<Cash> GetAll();
    }
}
