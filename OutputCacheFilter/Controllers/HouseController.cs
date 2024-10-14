using OutputCacheFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCacheFilter.Controllers
{
    public class HouseController : Controller
    {
        FarmerDBEntities db = new FarmerDBEntities();

        [OutputCache(Duration = 10, Location = System.Web.UI.OutputCacheLocation.Server)] /*The result of this index method store in Outputcache for 10 sec. */
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }

        [OutputCache(Duration = 40)]  /*if any data is added in this table or list the new data is not show in the table for 40 sec.*/
        public ActionResult GetData()
        {
            var data = db.FarmerInfoes.ToList();
            return View(data);
        }

    }
}