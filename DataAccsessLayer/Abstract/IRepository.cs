using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T P);
        T Get(Expression<Func<T, bool>> filter);
        void Update(T P);
        void Delete(T P);
        List<T> List(Expression<Func<T, bool>> filter); //şartlı listeleme
    }
}
