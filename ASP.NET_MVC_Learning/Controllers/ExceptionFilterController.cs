using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Learning.Controllers
{
    //don't add exception filter because it is bydefault added , don't follow following steps
    //[HandleError]  //If any exception throw in our action method then  [HandleError]  displays friendly view
    public class ExceptionFilterController : Controller
    {
        //[HandleError]
        public ActionResult Index()
        {
            /* divide by zero exception
            int a = 10;
            int b = 0;
            int c = a / b; */

            /* Null reference exception
            string a = null;
            int b = a.Length; */

            /*Index OutOf Range Exception
            int[] a = new int[3];
            a[0] = 11;
            a[1] = 22;
            a[2] = 33;
            a[3] = 44;*/


            /* If you think that on this line exception comes then place that line or code in the try catch
             If you want to handle exception to yourself use try catch

            try
            {
                throw new Exception();  //IF YOU WANT TO EXPLICITLY THROW EXCETION USE THIS LINE
            }
            catch(Exception ex)
            {
                return RedirectToAction("ErrorPage", "ExceptionFilter");
            }
            */

            throw new Exception();
            return View();
        }

       /* public ActionResult ErrorPage()
        {
            return View();
        }
       */

        public ActionResult About()
        {
            throw new Exception();
            return View();
        }

    }
}