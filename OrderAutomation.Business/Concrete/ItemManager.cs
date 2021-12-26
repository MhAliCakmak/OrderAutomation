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
    public class ItemManager : IItemServices
    {
        private IItemDal _itemDal;

        public ItemManager(IItemDal itemDal)
        {
            _itemDal = itemDal;
        }

        public void Add(Item item)
        {
            _itemDal.Add(item);
        }

        public void Delete(Item item)
        {
            try
            {
                _itemDal.Delete(item);
            }
            catch (Exception)
            {

                throw new Exception("Silme Gerçekleştirilemedi");
            }
        }

        public List<Item> GetAll()
        {
            return _itemDal.GetAll();
        }

        public int GetPriceForWuantity(int quantity, int tbxPrice)
        {
            int tbxprice = Convert.ToInt32(tbxPrice);
            int price=1;
            if (quantity !=0)
            {
                price = Convert.ToInt32(tbxprice) * quantity;
            }
            else
            {
                price = Convert.ToInt32(tbxPrice);
            }

            return price;

        }

        public float GetWeightForQuantity(int quantity, float tbxweight)
        {
            float weight;
            if (quantity != 0)
            {
                weight = (float)(tbxweight * quantity);
            }
            else
            {
                weight = tbxweight;
            }

            return weight;
        }

        public void Update(Item item)
        {
            _itemDal.Update(item);
        }
    }
}
