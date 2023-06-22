using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //class: referans tip olabilir demek
    //IEntity: IEntity veya onu implemente edenler olabilir.
    //new(): newlenebilir olmalı
    public interface IEntitiyRepository<T> where T:class,IEntity,new() //referans tip olabilri demek.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtre yazabilmemizi sağlar. isterse null olabilir.
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        // List<T> GetAllByCategory(int categoryId);// ürünleri kategoriye göre filtreleme
    }
}
