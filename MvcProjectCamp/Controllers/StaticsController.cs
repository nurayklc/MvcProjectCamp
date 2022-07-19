using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class StaticsController : Controller
    {
        // GET: Statics
        Context context = new Context();
        public ActionResult Index()
        {
            var totalCategory = context.Categories.Count();
            ViewBag.TotalCategory = totalCategory;

            var subTitleCategory = context.Headings.Where(x => x.CategoryID == 18).Count();
            ViewBag.SubTitleCategory = subTitleCategory;

            var indexOfCharWithAuthor = context.Authors.Count(x => x.AuthorName.Contains("a"));
            ViewBag.IndexOfCharWithAuthor = indexOfCharWithAuthor;

            var mostTitle = context.Categories.Max(x => x.Headings.Count);
            ViewBag.MostTitle = mostTitle;

            var differentCategoryStatus = context.Categories.Where(x => x.CategoryStatus == true).Count() - context.Categories.Where(x => x.CategoryStatus == false).Count();
            ViewBag.DifferentCategoryStatus = differentCategoryStatus;

            return View();
        }
    }
}