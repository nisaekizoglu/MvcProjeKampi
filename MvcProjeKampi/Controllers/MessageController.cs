using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDal());
        public ActionResult Inbox(string p)
        {
            var messagelist = mm.GetListInbox(p);
            return View(messagelist);
        }
        public ActionResult Sendbox(string p)
        {
            var messagelist = mm.GetListSendbox(p);
            return View(messagelist);
        }
        public ActionResult GetInBoxMessagetDetails(int id)
        {
            var values = mm.GetById(id); //id ye göre verileri getirme
            return View(values);
        }
        public ActionResult GetSendBoxMessagetDetails(int id)
        {
            var values = mm.GetById(id); //id ye göre verileri getirme
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            p.MessageDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            mm.MessageAdd(p);
            return RedirectToAction("SendBox");
        }
    }
}