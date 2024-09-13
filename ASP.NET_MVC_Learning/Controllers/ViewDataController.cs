using ASP.NET_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData - get data from controller and send to the view
        public ActionResult Index()
        {
            //pass single value in ViewData's object
            ViewData["Message"] = "Message from View Data !!";  //here Message is the ViewData's Object
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            //pass array in ViewData's object
            string[] fruits = { "Banaba", "Apple", "Orang", "Grapes" };
            ViewData["FruitsArray"] = fruits;


           // pass list in ViewData's object
            ViewData["SportsList"] = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
                "Hally Ball"
            };

            //Retrive data from model add passes to the view
            Employee shubh = new Employee();
            shubh.EmpId = 11;
            shubh.EmpName = "Shubhangi";
            shubh.EmpDesignation = "Software Developer";

            ViewData["Employee"] = shubh;

            return View();
        }
    }
}