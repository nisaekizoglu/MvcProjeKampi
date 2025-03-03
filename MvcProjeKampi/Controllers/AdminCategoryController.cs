using BusinessLayer.Concrete;
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
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());    
         [Authorize(Roles="B")]
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryvalidator= new CategoryValidator();
            //ValidationResult results = categoryvalidator.Validate(p);
            //if (results.IsValid)
            //{
            //    cm.CategoryAdd(p);
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    foreach (var item in results.Error)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMesssage);
            //    }
            //}
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue=cm.GetByID(id);
            cm.CategoryDelete(categoryvalue); 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryvalues = cm.GetByID(id);
            return View(categoryvalues);
        }
        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }
    }
}