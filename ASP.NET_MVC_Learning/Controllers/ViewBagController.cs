using ASP.NET_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
            ViewBag.Message = "Message From ViewBag!!";  //here Message is the dynamic property.
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();

            string[] fruits = { "Apple", "Banana", "Strawberry", "Grapes" };
            ViewBag.fruitsArray = fruits;

            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Football",
                "Hocky",
                "Baseball"
            };

            Student pravin = new Student();

            pravin.StdId = 12;
            pravin.StdName = "Pravin";
            pravin.StdDesignation = "Fire Officer";

            ViewBag.StuentInfo = pravin;

            ViewBag.CommonMessage = "This message is accessible by both VieBag and ViewData";

            return View();
        }
    }
}