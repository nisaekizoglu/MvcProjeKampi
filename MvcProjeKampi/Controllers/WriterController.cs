using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        public ActionResult Index()
        {
            var writerValues = wm.GetList();
            return View(writerValues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
        //    WriterValidator validationRules = new WriterValidator();
        //    ValidationResults results = WriterValidator.Validate(p);
        //    if (results.IsValid)
        //    {
        //        wm.WriterAdd(p);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        foreach (var item in results.Error)
        //        {
        //            ModelState.AddModelError(item.propertyName, item.ErrorMessage);
        //        }
        //    }
            return View();
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writervalue= wm.GetByID(id);
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {
            wm.WriterUpdate(p);
            return RedirectToAction("Index");   
        }
    }
}