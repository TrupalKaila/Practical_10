using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class EmployeeController : Controller
    {
        //DisplayName action method is created and it gets the parameter string name
        //String name is the text which is passed in the URL after the controller name 
        public ActionResult DisplayName(string name)
        {
            // Name which is fetched from the URL is stored in viewbag which can be accessed in view
            ViewBag.Name = name;
            return View();
        }
    }
}