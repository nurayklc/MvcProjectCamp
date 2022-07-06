using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }

        public void AddCategory(Category category)
        {
            categoryDAL.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            categoryDAL.Delete(category);
        }

        public List<Category> GetCategories()
        {
            return categoryDAL.GetAll();
        }

        public Category GetCategory(int id)
        {
            return categoryDAL.GetById(x => x.CategoryID == id);
        }
    }
}
