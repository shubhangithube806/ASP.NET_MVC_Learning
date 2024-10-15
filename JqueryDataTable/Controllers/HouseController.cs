using JqueryDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryDataTable.Controllers
{
    public class HouseController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            var data = db.employes.ToList();
            return View(data);
        }
    }
}