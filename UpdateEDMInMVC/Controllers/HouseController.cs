using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpdateEDMInMVC.Models;

namespace UpdateEDMInMVC.Controllers
{
    public class HouseController : Controller
    {
        EDMExampleMVCEntities db = new EDMExampleMVCEntities();
            // GET: House
        public ActionResult Index()
        { 
        var data = db.Farmers.ToList();
            return View(data);
        }

        public ActionResult Book()
        {
            var data = db.Books.ToList();
            return View(data);
        }
    }
}