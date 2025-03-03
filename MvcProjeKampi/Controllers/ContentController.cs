using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class ContentController : Controller
    {
        ContentManager cm= new ContentManager(new EFContentDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllContent(string p)
        {
            var values = cm.GetList(p);       
            return View(values);
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues=cm.GetListHeadingById(id);
            return View(contentvalues);
        }
    }
}