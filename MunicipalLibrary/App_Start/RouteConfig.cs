using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MunicipalLibrary
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
                name: "ClientByMembershipDate",
                url: "client/search/{year}/{month}",
                defaults: new {Controller = "Client",action = "Search" }

        );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
