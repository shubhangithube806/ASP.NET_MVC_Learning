using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{

    /*
      1.Partial view allows you to reuse the partial view code
      2.We can use Partial view in diferent views
      3.We have to attach partial view in some other view
      4.add Partial view in shared folder
      5. 2 Types of partial view 
       a.Static (Views whose layout not changed i.e header, navbar, footer) - Html.Partial, Html.RenderPartial
       b.Dynamic (Views whose contents change dynamically- Html.Action, Html.RenderAction
     */
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}