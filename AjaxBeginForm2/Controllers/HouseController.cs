using AjaxBeginForm2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginForm2.Controllers
{
    public class HouseController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            return View(db.employes.ToList());
        }

        [HttpPost]
        public ActionResult Index(string q)
        {
            if (string.IsNullOrEmpty(q) == false)
            {
                List<employe> emp = db.employes.Where(model => model.Name.StartsWith(q)).ToList();
                return PartialView("_SearchData", emp);
            }
            else
            {
                List<employe> emp = db.employes.ToList();
                return PartialView("_SearchData", emp);
            }
            return View();
        }


    }
}