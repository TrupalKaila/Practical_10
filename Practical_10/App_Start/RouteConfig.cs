using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Practical_10
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //This route is made for the test1, When the URL is in this foramt (http://localhost:61465/Employee/Mark) then this route will take care of that request
            //And the text after Employee/... will be passed to the action method
            routes.MapRoute(
                name: "Test1",
                url: "Employee/{name}",
                defaults: new { controller = "Employee", action = "DisplayName" }
                );

            // Is is simple routing for Test2
            routes.MapRoute(
                name: "Test2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ActionResultTest", action = "DisplayViewResult", id = UrlParameter.Optional }
            );

            // Is is simple routing for Test3
            routes.MapRoute(
                name: "Test3",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "OutputCache", action = "Index", id = UrlParameter.Optional }
            );

            // Is is simple routing for Test4
            routes.MapRoute(
                name: "Test4",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Handler", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
