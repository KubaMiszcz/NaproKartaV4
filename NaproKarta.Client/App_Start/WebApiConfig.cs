﻿using System.Web.Http;
using System.Web.Http.Cors;

namespace NaproKarta.Client
{
   public static class WebApiConfig
   {
      public static void Register(HttpConfiguration config)
      {
         // Web API configuration and services

         // Web API routes
         config.MapHttpAttributeRoutes();

         //enable CORS across the API without annotating each controller:
         //var corsAttr = new EnableCorsAttribute("http://localhost:4200", "*", "*");
         //config.EnableCors(corsAttr);




         config.Routes.MapHttpRoute(
            name: "DefaultApiWithAction",
            routeTemplate: "api/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional });

         config.Routes.MapHttpRoute(
             name: "DefaultApi",
             routeTemplate: "api/{controller}/{id}",
             defaults: new { id = RouteParameter.Optional }
            );



      }
   }
}