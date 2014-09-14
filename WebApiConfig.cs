using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using <use helper class here>;
using System.Web.Routing;

namespace <ns>
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //       name: "ActionApi",
            //       routeTemplate: "api/{controller}/{action}/{id}",
            //       defaults: new { id = RouteParameter.Optional }//,
            //    //constraints: new { id = @"^[0-9]+$" }
            //   );

            RouteTable.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            ).RouteHandler = new SessionRouteHandler();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
