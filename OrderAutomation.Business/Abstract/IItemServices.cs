using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Business.Abstract
{
    public interface IItemServices
    {
        void Add(Item item);
        void Delete(Item item);
        void Update(Item item);
        List<Item> GetAll();
        int GetPriceForWuantity(int quantity,int tbxPrice);
        float GetWeightForQuantity(int quantity, float tbxweight);
    }
}

