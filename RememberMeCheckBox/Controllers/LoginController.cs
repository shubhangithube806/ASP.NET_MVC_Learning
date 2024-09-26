using RememberMeCheckBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RememberMeCheckBox.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            //make cookie and create object 
            HttpCookie cookie = Request.Cookies["User"];
            if (cookie != null)
            {
                ViewBag.username = cookie["username"].ToString();

                string EncryptedPassword = cookie["password"].ToString();
                byte[] b = Convert.FromBase64String(EncryptedPassword);
                string decryptPassword = ASCIIEncoding.ASCII.GetString(b);

                //ViewBag.password = cookie["password"].ToString();
                ViewBag.password = decryptPassword.ToString();
            }
            return View();
        }


        [HttpPost]
        public ActionResult Index(User u)
        {
            //take HttpCookie class to make cookie and create object of that cookie and give name to the cookie "User"
            HttpCookie cookie = new HttpCookie("User");
            if (ModelState.IsValid == true)
            {
                if (u.RememberMe == true)
                {
                    //make variable of that object
                    cookie["username"] = u.username;

                    byte[] b = ASCIIEncoding.ASCII.GetBytes(u.password);
                    string EncryptedPassword = Convert.ToBase64String(b);

                    cookie["password"] = EncryptedPassword;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    //save cookie in the browser
                    HttpContext.Response.Cookies.Add(cookie);
                }
                else
                {
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Response.Cookies.Add(cookie);
                }

                var row = db.Users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
                if (row != null)  //their is row in the table match with textbox  data
                {
                    Session["Username"] = u.username;
                    TempData["Message"] = "<script>alert('Login Successfull !!')</script>";
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    TempData["Message"] = "<script>alert('Login Failed !!')</script>";
            }

            }
            return View();
        }
    }
}