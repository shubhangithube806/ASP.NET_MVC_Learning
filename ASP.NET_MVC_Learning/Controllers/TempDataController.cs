using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class TempDataController : Controller
    {
        /* 1.TempData is a Dictionary object derived from the TempDataDictionary class.
              2.Syntax TempData["objectname"] = "value";
              3.It must be typecast before use
              4.We use TempData to pass data from one actionmethod to another action method's view.
        */

        // GET: TempData
        public ActionResult Index()
        {
            ViewData["Var1"] = "Message comes from ViewData";
            ViewBag.Var2 = "Message comes from ViewBag";
            TempData["Var3"] = "Message comes from TempData";

            string[] games = { "Cricket", "Football", "Hallyball" };

            TempData["GameArray"] = games;

            return View();
        }

        public ActionResult About()
        {
            if(TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }

            return View();
        }
    }
}