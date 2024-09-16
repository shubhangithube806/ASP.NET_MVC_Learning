using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            // Create object
            ViewData["data1"] = "Data comes from viewdata";
            ViewBag.data2 = "Data comes from viebag";
            TempData["data3"] = "Data comes from tempdata";
            Session["data4"] = "Data comes from session";

            //CREATE ARRAY AND RETRIVE IT
            string[] Student = { "Aryan", "Pooja", "Shubh", "Ravina" };

            Session["data5"] = Student;

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
    }
}