using CrudAppWithImagesInMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudAppWithImagesInMVC.Controllers
{
    public class HouseController : Controller
    {
        ExampleDBEntities db = new ExampleDBEntities();
        // GET: House
        public ActionResult Index()
        {
            var data = db.Employes.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employe e)
        {
            if (ModelState.IsValid == true)
            {
                string fileName = Path.GetFileNameWithoutExtension(e.ImageFile.FileName);
                string extension = Path.GetExtension(e.ImageFile.FileName);
                HttpPostedFileBase postedFile = e.ImageFile;
                int length = postedFile.ContentLength;

                if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
                {
                    if (length <= 1000000)  // 1MB =1000000
                    {
                        fileName = fileName + extension;
                        e.ImagePath = "~/Images/" + fileName;
                        fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                        e.ImageFile.SaveAs(fileName);
                        db.Employes.Add(e);
                        int a = db.SaveChanges();
                        if (a > 0)
                        {
                            TempData["CreateMessage"] = "<script>alert('Data Inserted Successfully')</script>";
                            ModelState.Clear();
                            return RedirectToAction("Index", "House");
                        }
                        else
                        {
                            TempData["CreateMessage"] = "<script>alert('Data Not Inserted')</script>";
                        }

                    }
                    else
                    {
                        TempData["SizeMessage"] = "<script>alert('Image Size Should be less than 1 MB')</script>";
                    }
                }
                else
                {
                    TempData["ExtensionMessage"] = "<script>alert('Format Not Supported')</script>";
                }

            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var EmployeeRow = db.Employes.Where(model => model.Id == id).FirstOrDefault();
            Session["Image"] = EmployeeRow.ImagePath;
            return View(EmployeeRow);
        }

        [HttpPost]
        public ActionResult Edit(Employe e)
        {
            if (ModelState.IsValid == true)
            {
                if (e.ImageFile != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(e.ImageFile.FileName);
                    string extension = Path.GetExtension(e.ImageFile.FileName);
                    HttpPostedFileBase postedFile = e.ImageFile;
                    int length = postedFile.ContentLength;

                    if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
                    {
                        if (length <= 1000000)  // 1MB =1000000
                        {
                            fileName = fileName + extension;
                            e.ImagePath = "~/Images/" + fileName;
                            fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                            e.ImageFile.SaveAs(fileName);
                            db.Entry(e).State = EntityState.Modified;
                            int a = db.SaveChanges();
                            if (a > 0)
                            {
                                string Imagepath = Request.MapPath(Session["Image"].ToString());
                                if (System.IO.File.Exists(Imagepath))  //THIS particular image is exist in the folder
                                {
                                    System.IO.File.Delete(Imagepath);
                                }

                                TempData["UpdateMessage"] = "<script>alert('Data Updated Successfully')</script>";
                                ModelState.Clear();
                                return RedirectToAction("Index", "House");
                            }
                            else
                            {
                                TempData["UpdateMessage"] = "<script>alert('Data Not Updated')</script>";
                            }

                        }
                        else
                        {
                            TempData["SizeMessage"] = "<script>alert('Image Size Should be less than 1 MB')</script>";
                        }
                    }
                    else
                    {
                        TempData["ExtensionMessage"] = "<script>alert('Format Not Supported')</script>";
                    }

                }
                else
                {
                    e.ImagePath = Session["Image"].ToString();
                    db.Entry(e).State = EntityState.Modified;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["UpdateMessage"] = "<script>alert('Data Updated Successfully')</script>";
                        ModelState.Clear();
                        return RedirectToAction("Index", "House");
                    }
                    else
                    {
                        TempData["UpdateMessage"] = "<script>alert('Data Not Updated')</script>";
                    }

                }
            }
           
            return View();
        }


        public ActionResult Delete(int id)
        {

            if (id > 0)
            {
                var row = db.Employes.Where(model => model.Id == id).FirstOrDefault();

                if (row != null)
                {
                    db.Entry(row).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Deleted Successfully')</script>";
                        //To delete deleted images from the application from Images Folder
                        string Imagepath = Request.MapPath(row.ImagePath.ToString());
                        if (System.IO.File.Exists(Imagepath))  //THIS particular image is exist in the folder
                        {
                            System.IO.File.Delete(Imagepath);
                        }
                    }
                    else
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Not Deleted')</script>";
                    }
                }
            }
            return RedirectToAction("Index", "House");
        }

        public ActionResult Details(int id)
        {
            var row = db.Employes.Where(model => model.Id == id).FirstOrDefault();
            Session["Image2"] = row.ImagePath.ToString();

            return View(row);
        }
    }
}