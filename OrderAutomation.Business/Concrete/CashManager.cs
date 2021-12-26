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
    public class CashManager : ICashServices
    {
        private ICashDal _cashDal;

        public CashManager(ICashDal cashDal)
        {
            _cashDal = cashDal;
        }

        public void Add(Cash cash)
        {
            _cashDal.Add(cash);
        }

        public void Delete(Cash cash)
        {
            try
            {
                _cashDal.Delete(cash);
            }
            catch (Exception)
            {

                throw new Exception("Silme Gerçekleştirilemedi");
            }
        }

        public List<Cash> GetAll()
        {
            return _cashDal.GetAll();
        }

        public void Update(Cash cash)
        {
            _cashDal.Update(cash);
        }
    }
}
