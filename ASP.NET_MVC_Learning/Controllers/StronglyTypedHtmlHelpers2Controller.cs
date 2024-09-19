using ASP.NET_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class StronglyTypedHtmlHelpers2Controller : Controller
    {
        // GET: StronglyTypedHtmlHelpers2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculation c)   //here i made object of CaLculation class i.e "c"
        {
            int num1 = c.num1;   //here num1 ,num2 transfer to local varial
            int num2 = c.num2;
            int result = num1 + num2;

            ViewBag.result = result;

            return View();
        }
    }
}