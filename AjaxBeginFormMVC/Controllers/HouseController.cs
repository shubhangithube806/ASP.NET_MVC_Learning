using AjaxBeginFormMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginFormMVC.Controllers
{
    public class HouseController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(employe e)
        {
            if (ModelState.IsValid == true)
            {
                db.employes.Add(e);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    // return Json("Data Inserted !!");
                    return JavaScript("alert('Data Inserted !!')");  //JavaScript Object Notation
                }
                else
                {
                    // return Json("Data Not Inserted !!");
                    return JavaScript("alert('Data Not Inserted !!')");
                }
            }
            return View();
        }

       
    }
}