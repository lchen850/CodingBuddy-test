using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CodingBuddy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Enables attribute routing
            routes.MapMvcAttributeRoutes(); // Custom routes now visible in Controller instead of in this file

            // Practice custom route: must go before the default/generic route
            //routes.MapRoute(
            //    "TestCustomRoute", // Unique name
            //    "Test/CustomRoute/{year}/{month}", // URL route
            //    new { controller = "Test", action = "CustomRoute" }, // Use an anonymous object for defaults
            //    new { year = @"\d{4}", month = @"\d{2}" } // Parameter constraints for year and month
            //);

            // A "Default" route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // Passes the user request to the correct controller - method/action - optional ID
                // Default route: Home controller, Index action
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } 
            );
        }
    }
}
