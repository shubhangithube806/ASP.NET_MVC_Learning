using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class UrlActionController : Controller
    {
        // GET: UrlAction
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }
    }
}