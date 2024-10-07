using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignUpWithLoginMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Logout()
        {
            Session.Abandon();  //meas distroy session after logout
            return RedirectToAction("Index", "Login");
        }
    }
}