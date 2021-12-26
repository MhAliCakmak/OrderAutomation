using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Abstract
{
    public interface ICreditServices
    {
        void Add(Credit credit);
        void Delete(Credit credit);
        void Update(Credit credit);
        List<Credit> GetAll();
    }
}
