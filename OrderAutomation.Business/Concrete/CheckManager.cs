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
    public class CheckManager : ICheckServices
    {
        private ICheckDal _checkDal;

        public CheckManager(ICheckDal checkDal)
        {
            _checkDal = checkDal;
        }

        public void Add(Check check)
        {
            _checkDal.Add(check);
        }

        public void Delete(Check check)
        {
            try
            {
                _checkDal.Delete(check);
            }
            catch (Exception)
            {

                throw new Exception("Silme Gerçekleştirilemedi");
            }
        }

        public List<Check> GetAll()
        {
            return _checkDal.GetAll();
        }

        public void Update(Check check)
        {
            _checkDal.Update(check);
        }
    }
}
