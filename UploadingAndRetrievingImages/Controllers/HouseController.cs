using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadingAndRetrievingImages.Models;

namespace UploadingAndRetrievingImages.Controllers
{
    public class HouseController : Controller
    {

        ImageDBEntities db = new ImageDBEntities();
        // GET: House

        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Student s)
        {
            //to get image file name
            //fileName gose to the images folder and ImagePath IS GOSE TO THE DATABASE

            string fileName = Path.GetFileNameWithoutExtension(s.ImageFile.FileName);
            string extension = Path.GetExtension(s.ImageFile.FileName);
            HttpPostedFileBase postedFile = s.ImageFile;
            int length = postedFile.ContentLength;   //get length in bytes

            if (extension.ToLower() == ".jpg" || extension.ToLower() == ".png" || extension.ToLower() == ".jpeg") 
            {
                if (length <= 1000000) //1000000  = 1MB
                {
                    fileName = fileName + extension;
                    s.ImagePath = "~/Images/" + fileName;  // ~ indicates your project

                    fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                    s.ImageFile.SaveAs(fileName);    //SAVE image in the Images folder
                    db.Students.Add(s);

                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        ViewBag.Message = "<script>alert('Record Inserted !!')</script>";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "<script>alert('Record Not Inserted !!')</script>";
                    }
                }
                else
                {
                    ViewBag.SizeMessage = "<script>alert('Size Should be of 1 MB !!')<script/> ";
                }
            }
            else
            {
                ViewBag.ExtensionMessage = "<script>alert('Image Not Supported !!')<script/> ";
            }
            
            return View();
        }
    }
}