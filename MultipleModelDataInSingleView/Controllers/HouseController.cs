using MultipleModelDataInSingleView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleModelDataInSingleView.Controllers
{
    public class HouseController : Controller
    {
        SchoolDBEntities db = new SchoolDBEntities();
        public ActionResult Index()
        {
            //var std = GetStudents();
            //var tchr = GetTeachers();

            //By using ViewBag
            //ViewBag.student = std;
            //ViewBag.teacher = tchr;

            ////By using ViewData
            //ViewData["student"] = std;
            //ViewData["teacher"] = tchr;

            ////By using TempData
            //TempData["student"] = std;
            //TempData["teacher"] = tchr;

            //By using Session
            //Session["student"] = std;
            //Session["teacher"] = tchr;

            //By creating extra class in model folder
            //MultiModelData data = new MultiModelData();
            //data.MyStudents = std;
            //data.MyTeachers = tchr;
            //return View(data);

            return View();
        }

        //ByUSING PARTIAL VIEW MAKE THIS ACTION METHOD
        public PartialViewResult Students()
        {
            var std = GetStudents();
            return PartialView("_Students", std);
        }

        public PartialViewResult Teachers()
        {
            var tchr = GetTeachers();
            return PartialView("_Teachers", tchr);
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public List<Teacher> GetTeachers()
        {
            return db.Teachers.ToList();
        }
    }
}