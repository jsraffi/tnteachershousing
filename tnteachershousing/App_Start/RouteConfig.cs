using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace tnteachershousing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Applciation",
                url: "{controller}/{action}/{applicationid}",
                defaults: new { controller = "Admin", action = "Index"}
            );
            routes.MapRoute(
                name: "Project",
                url: "{controller}/{action}/{projectid}",
                defaults: new { controller = "Admin", action = "Index"}
            );

            routes.MapRoute(
                name: "allotment",
                url: "{controller}/{action}/{productname}/{id}",
                defaults: new { controller = "Project", action = "Index"}
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
