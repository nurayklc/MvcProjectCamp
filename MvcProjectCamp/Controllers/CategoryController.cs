using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDAL());
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetCategoryList()
        {
            var categoryList = categoryManager.GetCategories();
            return View(categoryList);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            //categoryManager.Add(category);
            return RedirectToAction("GetCategoryList");
        }
        //public ActionResult DeleteCategory()
    }
}