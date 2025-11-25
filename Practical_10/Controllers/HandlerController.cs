using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class HandlerController : Controller
    {
        //In Index method dividebyzero exception thrown, to handle that exception we had used HandleError attribute we can use this attribute for single action method or controller or we can also give it globally
        //We have to create error view in shared view, handle error automatically gets the view which is named as "Error.cshtml" 
        //If we want to handle specific error so we can also create view based on that and in handle error attribute pass that view as parameter
        //Note: In web.config -> system.web we have to enable custom error 
        [HandleError(ExceptionType = typeof(DivideByZeroException), View ="DivideByZeroException")]
        [HandleError]
        public ActionResult Index()
        {
            throw new DivideByZeroException();
            return View();
        }
    }
}