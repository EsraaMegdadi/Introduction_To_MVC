using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Introduction_To_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
          //  routes.IgnoreRoute("Computer/Display ");


            routes.MapRoute(
                name: "Default",
                url: "{action}/{controller}/{id}",
                defaults: new { controller = "Computer", action = "Display", id = UrlParameter.Optional }
            );
        }
    }
}
