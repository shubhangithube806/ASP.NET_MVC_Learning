using ASP.NET_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    public class StronglyTypedPartialViewController : Controller
    {
        // GET: StronglyTypedPartialView

        List<Product> ProductList = new List<Product>()
        {
            new Product {id = 1, name = "Shoes", price = 10000.00, picture = "~/Images/shoes.jpg"},
            new Product {id = 2, name = "Sunglasees", price = 1000.00, picture = "~/Images/gogle.jpg"},
            new Product {id = 3, name = "Rolax Watch", price = 5000.00, picture = "~/Images/watch.jpg"}
        };

        public ActionResult Index()
        {
            return View(ProductList);
        }
    }
}