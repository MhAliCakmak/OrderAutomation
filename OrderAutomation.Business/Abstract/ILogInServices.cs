using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Abstract
{
    public interface ILogInServices
    {
        void Add(LogIn logIn);
        void Delete(LogIn logIn);
        void Update(LogIn logIn);
        List<LogIn> GetAll();
        LogIn GetLogInbyEPostaPassword(string eposta, string password);
    }
}
