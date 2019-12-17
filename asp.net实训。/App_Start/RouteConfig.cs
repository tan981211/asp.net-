using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace asp.net实训_
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "charge", action = "Index", id = UrlParameter.Optional }
            );
            //routes.MapRoute(
            //     "charge",
            //    "{controller}/{action}/{id}",
            //     new { controller = "charge", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    "user",
            //    "{controller}/{action}/{id}",
            //    new { controller = "user", action = "Index", id = UrlParameter.Optional }
            //);
            
        }
    }
}
