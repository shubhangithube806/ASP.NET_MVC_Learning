using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginFormEFDatabaseFirst.Controllers
{
    public class HouseController : Controller
    {
        // GET: House
        public ActionResult Index()
        {
            if (Session["username"] == null)   //user come to this page without login
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}