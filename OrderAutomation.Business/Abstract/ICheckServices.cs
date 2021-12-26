using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Abstract
{
    public interface ICheckServices
    {
        void Add(Check check);
        void Delete(Check check);
        void Update(Check check);
        List<Check> GetAll();
    }
}
