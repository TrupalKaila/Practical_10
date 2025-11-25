using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class OutputCacheController : Controller
    {
        //Output cache is used when one action method is called multiple times so if we use outputcache with duration then it will store the returned output in cache for that interval
        //It helps for enhancing the performance, it reduces the call to action methods
        [OutputCache(Duration = 300)]
        public ActionResult Index()
        {
            ViewBag.Date = DateTime.Now;
            return View();
        }
    }
}