using AjaxMVCLoadMoreData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxMVCLoadMoreData.Controllers
{
    public class HouseController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            int num = 5;
            Session["data"] = num; //get rows and store in session
            var data = db.employes.ToList().Take(num);
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(employe e)
        {
            int rows = Convert.ToInt32(Session["data"]) + 5;  //here total get rows are 10
            var data = db.employes.ToList().Take(rows);
            Session["data"] = rows;
            return PartialView("_EmpData", data);
        }
    }
}