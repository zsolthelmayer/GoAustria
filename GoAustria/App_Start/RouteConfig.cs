using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GoAustria
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Adatkezeles",
				url: "adatkezeles/{id}",
				defaults: new { controller = "Adatkezeles", action = "Index" }
			);


			routes.MapRoute(
				name: "Aszf",
				url: "aszf/{id}",
				defaults: new { controller = "Aszf", action = "Index" }
			);


			routes.MapRoute(
                name: "Default",
                url: "{action}/{id}",
                defaults: new { controller = "Link", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Blog",
                url: "blog/{id}",
                defaults: new { controller = "Blog", action = "Index" }
            );
        }
    }
}

