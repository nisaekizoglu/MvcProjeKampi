﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet] //sayfa yüklendiği zaman çalışır
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] //butona tıklandığı zaman çalışır
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);
            CategoryValidator categoryValidator = new CategoryValidator(); //validasyon kuralları devreye girmesi için kullandık
            //ValidationResult results = categoryValidator.Validate(p);
            //if (results.IsValid)
            //{
            //    cm.CategoryAdd(p);
            //    return RedirectToAction("GetCategoryList");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            return View();
        }
    }
}