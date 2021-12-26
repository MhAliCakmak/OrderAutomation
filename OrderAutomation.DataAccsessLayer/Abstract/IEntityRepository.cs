using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.DataAccsessLayer.Abstract
{
    //T:class(Referans tip olmalı),IEntity(IEntityden referans edilmeli yani veri tabanı nesnesi olmalı),new()(new lenebilir olmalı yani class olmalı)
    public interface IEntityRepository<T> where T : class, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
