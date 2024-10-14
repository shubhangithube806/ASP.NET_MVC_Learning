using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizeFilter.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
        [AllowAnonymous]  /*means anyone comes on this page*/
        public ActionResult Index()
        {
            return View();
        } 
        

        public ActionResult About()
        {
            return View();
        } 
        
       // [Authorize]
        public ActionResult Contact()
        {
            return View();
        }
    }
}