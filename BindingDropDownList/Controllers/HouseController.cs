using BindingDropDownList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BindingDropDownList.Controllers
{
    public class HouseController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            List<employe> empList = db.employes.ToList();
            ViewBag.EmployeeTbl =  new SelectList(empList, "Id", "Name");
            return View();
        }
    }
}