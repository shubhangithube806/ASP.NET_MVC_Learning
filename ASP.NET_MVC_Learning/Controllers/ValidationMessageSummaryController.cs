using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class ValidationMessageSummaryController : Controller
    {
        // GET: ValidationMessageSummary
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string fullName, string Age, string Email)  //make parameters
        {
            //when fullname is equal to empty i.e "" then equal method retunrs true
            if (fullName.Equals("") == true)
            {
                ModelState.AddModelError("fullName" , "Full Name is reuired !!");
                ViewData["fullNameError"] = "*";
            }

            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is reuired !!");
                ViewData["AgeError"] = "*";

            }

            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is reuired !!");
                ViewData["EmailError"] = "*";

            }


            if (ModelState.IsValid == true)
            {
                ViewData["successMessage"] = "<script>alert('Data has been submitted !!')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}