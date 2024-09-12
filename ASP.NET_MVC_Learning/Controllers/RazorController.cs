using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            return View();
        }
    }
}