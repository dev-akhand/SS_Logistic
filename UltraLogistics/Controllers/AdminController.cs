using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UltraLogistics.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddZipCode()
        {
            return View();
        }
        public ActionResult ViewZipCode()
        {
            return View();
        }
        public ActionResult AddBranch()
        {
            return View();
        }
        public ActionResult ViewBranch()
        {
            return View();
        }
        public ActionResult EditBranch()
        {
            return View();
        }
    }
}