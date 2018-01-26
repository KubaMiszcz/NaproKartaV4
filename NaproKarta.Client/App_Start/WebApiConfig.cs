using Newtonsoft.Json.Serialization;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using Unity.Lifetime;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Repositories;
using NaproKarta.Client.Resolver;
using NaproKarta.Client.Interfaces;
using NaproKarta.Client.Repositories;

namespace NaproKarta.Client
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services
			var container = new UnityContainer();
			container.RegisterType<IApplicationUserRepository, ApplicationUserRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IChartRepository, ChartRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IObservationRepository, ObservationRepository>(new HierarchicalLifetimeManager());
			//container.RegisterType<IObservationVmRepository, ObservationVmRepository>(new HierarchicalLifetimeManager());

			config.DependencyResolver = new UnityResolver(container);
			
			// Web API routes
			config.MapHttpAttributeRoutes();
			config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

			//config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
			//config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
			
			//enable CORS across the API without annotating each controller:
			//var corsAttr = new EnableCorsAttribute("http://localhost:4200", "*", "*");
			var cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors();

			config.Routes.MapHttpRoute(
			   name: "DefaultApi",
			   routeTemplate: "api/{controller}/{action}/{id}",
			   defaults: new { id = RouteParameter.Optional });

			config.Routes.MapHttpRoute(
				name: "DefaultApiWithAction",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			   );



		}
	}
}
