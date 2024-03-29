﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categorManager = new CategoryManager(new EFCategoryDAL());

        // GET: AdminCategory
        public ActionResult Index()
        {
            var categoryList = categorManager.GetCategories();
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
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result =  categoryValidator.Validate(category);
            if (result.IsValid)
            {
                categorManager.AddCategory(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var categoryValue = categorManager.GetCategoryById(id);
            return View(categoryValue);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            categorManager.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var category = categorManager.GetCategoryById(id);
            categorManager.DeleteCategory(category);
            return RedirectToAction("Index");
        }
    }
}