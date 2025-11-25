using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
    public class ActionResultTestController : Controller
    {
        //ContentResult is used to return the content in different format like HTMl format, javascript or any.
        public ContentResult DisplayContentResult()
        {
            return Content("<b>This is displayed from Display Content Result action method</b>","text/html");
        }
        //FileContentResult is used to return the text from the file which is stored in byte[] variable
        public FileContentResult DisplayFileContentResult()
        {
            byte[] file = System.IO.File.ReadAllBytes(Server.MapPath("~/Files/TextFile.txt"));
            return File(file, "text/plain");
        }
        //EmptyResult is used if we dont want to return anything and if we want to perform some operation
        public EmptyResult DisplayEmptyResult()
        {
            return new EmptyResult();
        }
        //JavascriptResult is used to return the javascript object 
        public JavaScriptResult DisplayJavaScriptResult()
        {
            string script = "alert('This alert is of JavaScript Result')";
            return JavaScript(script);
        }
        //JsonResult is used to return the Json object and we have to set jsonrequestbehaviour to allowget
        //reason of doing this is that it protects us from json attack

        public JsonResult DisplayJsonResult()
        {
            object obj = new { Name = "Peter", Age = 21};
            return Json(obj,JsonRequestBehavior.AllowGet);
        }
        //Returns view
        public ViewResult DisplayViewResult()
        {
            return View();
        }
    }
}