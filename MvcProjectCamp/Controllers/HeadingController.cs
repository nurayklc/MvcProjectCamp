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
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager headingManager = new HeadingManager(new EFHeadingDAL());
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDAL());
        AuthorManager authorManager = new AuthorManager(new EFAuthorDAL());
        public ActionResult Index()
        {
            var headingResult = headingManager.GetHeadings();
            return View(headingResult);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from category in categoryManager.GetCategories()
                                                  select new SelectListItem
                                                  {
                                                      Text = category.CategoryName,
                                                      Value = category.CategoryID.ToString()
                                                  }).ToList();
            List<SelectListItem> valueAuthor = (from author in authorManager.GetAuthorList()
                                                select new SelectListItem
                                                {
                                                    Text = author.AuthorName + " " + author.AuthorSurname,
                                                    Value = author.AuthorID.ToString()
                                                }).ToList();
            ViewBag.ValueCategory = valueCategory;
            ViewBag.ValueAuthor = valueAuthor;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            headingManager.AddHeading(heading);
            return RedirectToAction("Index");
        }
    }
}