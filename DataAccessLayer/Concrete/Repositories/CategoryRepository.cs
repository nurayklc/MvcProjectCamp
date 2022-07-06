using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context _context = new Context();
        DbSet<Category> _categoryObject;

        public void Add(Category category)
        {
            _categoryObject.Add(category);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _categoryObject.ToList();
        }

        public void Update(Category category)
        {
            _context.SaveChanges();
        }
        public void Delete(Category category)
        {
            _categoryObject.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetFilterList(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category GetById(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
