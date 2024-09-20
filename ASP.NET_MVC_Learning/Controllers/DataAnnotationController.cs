using ASP.NET_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class DataAnnotationController : Controller
    {
        // GET: DataAnnotation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Farmer e)
        {
            if (ModelState.IsValid == true)  //means their is no error in the form, all requird fields are fill
            {
                ViewData["SuccessMessage"] = "<script>alert('Data has been Submitted !!')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}