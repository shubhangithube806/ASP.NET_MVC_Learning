using AjaxActionLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxActionLink.Controllers
{
    public class HouseController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllEmployees()
        {
            var data = db.employes.ToList();
            return PartialView("_Employees", data);    //partialView is made in shared folder , this view is shared every where so use _ prefix infront of name
        }

        public ActionResult Top3Emp()
        {
            var data = db.employes.OrderByDescending(model => model.Salary).Take(3).ToList();
            return PartialView("_Employees", data);
        }

        public ActionResult Bottom3Emp()
        {
            var data = db.employes.OrderBy(model => model.Salary).Take(3).ToList();
            return PartialView("_Employees", data);
        }
    }
}