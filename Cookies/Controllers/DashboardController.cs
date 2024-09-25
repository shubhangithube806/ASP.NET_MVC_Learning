using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["UserName"];  //Request ki class use karte hai jab hame cookies se data retrive krvana hai toh
            if (cookie != null) 
            {
                ViewBag.Message = Request.Cookies["UserName"].Value.ToString();
            }
            else
            {
                return RedirectToAction("Index", "House");
            }
            return View();
        }
    }
}