using Cookies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class HouseController : Controller
    {
        // GET: House
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User u)
        {
            if (ModelState.IsValid == true)
            {
                //create cookie and store username come from the user in cookie object
                HttpCookie cookie = new HttpCookie("UserName");
                cookie.Value = u.UserName;

                //save cookie in the browser memory
                HttpContext.Response.Cookies.Add(cookie);
                //below line is used to make persistant/permanant cookie
                cookie.Expires = DateTime.Now.AddDays(2);
                return RedirectToAction("Index", "Dashboard");

            }
            return View();
        }
    }
}