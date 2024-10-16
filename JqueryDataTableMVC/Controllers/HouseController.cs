using JqueryDataTableMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryDataTableMVC.Controllers
{
    public class HouseController : Controller
    {
        JqueryEmployeeDBEntities db = new JqueryEmployeeDBEntities();
        // GET: House
        public ActionResult Index()
        {
            var data = db.employees.ToList();
            return View(data);
        }
    }
}