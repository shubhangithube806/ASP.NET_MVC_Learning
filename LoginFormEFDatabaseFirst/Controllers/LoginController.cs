using LoginFormEFDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginFormEFDatabaseFirst.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User u)
        {
            if (ModelState.IsValid == true)   // credentials this word means password and username
            {
                var credentials = db.Users.Where(model => model.UserName == u.UserName && model.Password == u.Password).FirstOrDefault();
                if (credentials == null)
                {
                    ViewBag.ErrorMessage = "Login Failed";
                    return View();
                }
                else
                {Session["username"] = u.UserName;
                 return RedirectToAction("Index", "House");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();  //destroy the session
            return RedirectToAction("Index", "Login");
        }

        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Login");
        }

    }
}