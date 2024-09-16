using ASP.NET_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class StronglyTypedViewController : Controller
    {
        // GET: StronglyTypedView

        public ActionResult Index()
        {
            Employe db = new Employe();
            db.Id = 1234;
            db.Name = "Shubhangi";
            db.Age = 25;

            Employe db1 = new Employe();
            db1.Id = 1235;
            db1.Name = "Pravin";
            db1.Age = 24;

            Employe db2 = new Employe();
            db2.Id = 1236;
            db2.Name = "Arya";
            db2.Age = 21;

            List<Employe> EmployeList = new List<Employe>();
            EmployeList.Add(db);
            EmployeList.Add(db1);
            EmployeList.Add(db2);

            /* ViewData["var1"] = db;
             ViewBag.var2 = db; */

            return View(EmployeList);
        }
    }
}