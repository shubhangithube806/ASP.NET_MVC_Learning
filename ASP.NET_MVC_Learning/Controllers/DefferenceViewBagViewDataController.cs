using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class DefferenceViewBagViewDataController : Controller
    {
        // GET: DefferenceViewBagViewData
        public ActionResult Index()
        {
            ViewData["Message1"] = "Data comes from ViewData";
            ViewBag.Message2 = "Data comes from ViewBag";

            ViewData["CurrentTime1"] = DateTime.Now.ToLongTimeString(); 
            ViewBag.CurrentTime2 = DateTime.Now.ToLongTimeString();

            string[] fruits = { "Apple", "Orange", "Banana" };

            ViewData["FruitsArray1"] = fruits;
            ViewBag.FruitsArray2= fruits;


            return View();
        }
    }
}