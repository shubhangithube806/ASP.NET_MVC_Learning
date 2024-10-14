using AuthorizeFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthorizeFilter.Controllers
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
        public ActionResult Index(User u, string ReturnUrl)
        {
            if (IsValid(u) == true)
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                Session["username"] = u.UserName.ToString();
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "House");
                }
            }
            else
            {
                return View();
            }
           
        }

        public bool IsValid(User u)
        {
            var credentials = db.Users.Where(model => model.UserName == u.UserName && model.Password == u.Password).FirstOrDefault();

            if (credentials != null)
            {
                return (u.UserName == credentials.UserName && u.Password == credentials.Password);
            }
            else
            {
                return false;
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["username"] = null;
            return RedirectToAction("Index", "House");
        }
    }
}