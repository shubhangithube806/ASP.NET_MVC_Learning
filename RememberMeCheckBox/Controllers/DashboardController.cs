﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RememberMeCheckBox.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if (Session["Username"]  == null)
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
            if (Session["Username"] != null)
            {
                Session.Abandon();  //Abandon MEANS DISTROY
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}