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
        public ActionResult Index()
        {
            var headingResult = headingManager.GetHeadings();
            return View(headingResult);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            headingManager.AddHeading(heading);
            return RedirectToAction("Index");
        }
    }
}