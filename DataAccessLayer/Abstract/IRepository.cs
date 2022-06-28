using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T param);
        void Update(T param);
        void Delete(T param);
        List<T> GetFilterList(Expression<Func<T, bool>> filter);
    }
}
