using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UltraLogistics.Models;

namespace UltraLogistics.Controllers
{
    public class AdminController : Controller
    {
        DBManager db = new DBManager();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddZipCode()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parms =
            {
                new SqlParameter("@Action", 3)
            };
            dt = db.Proc_GetAllRecord("proc_Pincode", parms);
            ViewBag.Record = dt;
            return View();
        }
        [HttpPost]
        public ActionResult AddZipCode(string DdlPincode)
        {
            bool res = false;
            SqlParameter[] parm =
            {
                new SqlParameter("@Action",1),
                new SqlParameter("@PinId",DdlPincode)
            };
            res = db.IUD("proc_Pincode", parm);
            ViewBag.Mess = "ZipCode is Activate...";

            DataTable dts = new DataTable();
            SqlParameter[] parms =
            {
                new SqlParameter("@Action", 3)
            };
            dts = db.Proc_GetAllRecord("proc_Pincode", parms);
            ViewBag.Record = dts;

            return View();
        }
        [HttpGet]
        public ActionResult ViewZipCode()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parms =
            {
                new SqlParameter("@Action", 4)
            };
            dt = db.Proc_GetAllRecord("proc_Pincode", parms);
            ViewBag.Record = dt;
            return View();
        }
        public ActionResult ViewZipCodes(int PinId)
        {
            bool res = false;
            SqlParameter[] parm =
            {
                new SqlParameter("@PinId",PinId),
                new SqlParameter("@Action",2)
            };
            res = db.IUD("proc_Pincode", parm);
            Response.Write("<script>alert('ZipCodes is DeActivate')</script>");

            DataTable dt = new DataTable();
            SqlParameter[] parms =
            {
                new SqlParameter("@Action", 4)
            };
            dt = db.Proc_GetAllRecord("proc_Pincode", parms);
            ViewBag.Record = dt;

            return View("ViewZipCode");
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