using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class ActionMethodController : Controller
    {
        // GET: ActionMethod
        public ActionResult Index()  //Action method cha return type ActionResult ahe.
        {
            return View();
        }

        public string Show()  //
        {
            return "This is a second action method of actionmethod controller";
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public int StudentId(int id)
        {
            return id;
        }

    }
}