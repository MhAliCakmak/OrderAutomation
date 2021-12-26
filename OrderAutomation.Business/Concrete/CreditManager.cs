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
    public class CreditManager : ICreditServices
    {
        private ICreditDal _creditDal;

        public CreditManager(ICreditDal creditDal)
        {
            _creditDal = creditDal;
        }

        public void Add(Credit credit)
        {
            _creditDal.Add(credit);
        }

        public void Delete(Credit credit)
        {
            try
            {
                _creditDal.Delete(credit);
            }
            catch (Exception)
            {

                throw new Exception("Silme Gerçekleştirilemedi.");
            }
        }

        public List<Credit> GetAll()
        {
            return _creditDal.GetAll();
        }

        public void Update(Credit credit)
        {
            _creditDal.Update(credit);
        }
    }
}
