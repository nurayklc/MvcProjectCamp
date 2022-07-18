using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context _context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = _context.Set<T>();
        }

        public void Add(T param)
        {
            var addEntity = _context.Entry(param);
            addEntity.State = EntityState.Added;
            //_object.Add(param);
            _context.SaveChanges();
        }

        public void Delete(T param)
        {
            var deleteEntity = _context.Entry(param);
            deleteEntity.State = EntityState.Deleted;
            //_object.Remove(param);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetFilterList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
        public void Update(T param)
        {
            var updateEntity = _context.Entry(param);
            updateEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
