using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author

        AuthorManager authorManager = new AuthorManager(new EFAuthorDAL());
        public ActionResult Index()
        {
            var AuthorValues = authorManager.GetAuthorList();
            return View(AuthorValues);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author author)
        {
            AuthorValidator authorValidation = new AuthorValidator();
            ValidationResult validationResults = authorValidation.Validate(author);
            if (validationResults.IsValid)
            {
                authorManager.AddAuthor(author);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResults.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult UpdateAuthor(int id)
        {
            var author = authorManager.GetAuthor(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult UpdateAuthor(Author author)
        {
            authorManager.UpdateAuthor(author);
            return RedirectToAction("Index");
        }
    }
}