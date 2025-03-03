using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDal());
        public ActionResult Index()
        {
            var contactvalues=cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues=cm.GetById(id); //id ye göre verileri getirme
            return View(contactvalues);
        }
        public PartialViewResult ContactSideBar()
        {
            return PartialView();
        }
    }
}