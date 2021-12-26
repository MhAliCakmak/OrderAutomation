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
    public class LogInManager : ILogInServices
    {
        private ILogInDal _logInDal;

        public LogInManager(ILogInDal logInDal)
        {
            _logInDal = logInDal;
        }

        public void Add(LogIn logIn)
        {
            _logInDal.Add(logIn);
        }

        public void Delete(LogIn logIn)
        {
            try
            {
                _logInDal.Delete(logIn);
            }
            catch (Exception)
            {

                throw new Exception("Silme Gerçekleştirilemedi");
            }
        }

        public List<LogIn> GetAll()
        {
            return _logInDal.GetAll();
        }

        public LogIn GetLogInbyEPostaPassword(string eposta, string password)
        {
            return _logInDal.Get(p => p.EPosta == eposta && p.Password == password);
        }

        public void Update(LogIn logIn)
        {
            _logInDal.Update(logIn);
        }
    }
}
