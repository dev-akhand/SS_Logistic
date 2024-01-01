using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UltraLogistics.Models;

namespace UltraLogistics.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MailSender ms)
        {
            string Subject = "Congratulation! ";
            string body = "Now Your are a Customer of UltaLogicties.....! ";
            ms.Send(ms.email, Subject, body);
            Response.Write("<script>alert('Your record is is fill Sucessfull')</script>");
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult Services()
        {

            return View();
        }
        public ActionResult Price()
        {
            return View();
        }
        public ActionResult Features()
        {
            return View();
        }
        public ActionResult Quote()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Testimonial()
        {
            return View();
        }


    }
}