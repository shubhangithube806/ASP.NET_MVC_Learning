using EFCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstApproach.Controllers
{
    public class CodeFirstController : Controller
    {
        StudentDbContext db = new StudentDbContext();
        // GET: CodeFirst
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid == true)        //IF THEIR IS NO ANY ERROR IN THE CREATED DATA THEN IT SAVE TO DATABASE

            {
                db.Students.Add(s);
                int a = db.SaveChanges();
                if (a > 0) //when one row is added
                {
                    //ViewBag.InsertMessage = "<script>alert('Data Inserted !!')</script>";
                   // TempData["InsertMessage"] = "<script>alert('Data Inserted !!')</script>";
                    TempData["InsertMessage"] = "Data Inserted !!";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted !!')</script>";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)   //id as parameter to catch Id
        {
            var row = db.Students.Where(model => model.Id == id).FirstOrDefault();  //where is the LINQ expression to write query in entity framework
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Student s)   //WHEN CLICK on the edit then the whole data comes to the s
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    //ViewBag.UpdateMessage = "<script>alert('Data Updated !!')</script>";
                    TempData["UpdateMessage"] = "Data Updated !!";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.UpdateMessage = "<script>alert('Data Not Updated !!')</script>";

                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var StudentIdRow = db.Students.Where(model => model.Id == id).FirstOrDefault();
                if (StudentIdRow != null)  // that id is present in the database means is not null
                {
                    db.Entry(StudentIdRow).State = EntityState.Deleted;
                    int a = db.SaveChanges();  //meas if row is deleted then a = 1  and if row is not deleted then a = 0 
                    if (a > 0)
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Deleted !!')</script>";
                    }
                    else
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Not Deleted !!')</script>";
                    }
                }

            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var DetailsById = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(DetailsById);
        }

       
    }
}