using NaproKarta.Client.Controllers;
using NaproKarta.Server.Context;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;

namespace NaproKarta.Client
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();
			container.RegisterType<AccountController>(new InjectionConstructor());
			container.RegisterType<HomeController>(new InjectionConstructor());
			container.RegisterType<ManageController>(new InjectionConstructor());

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}
	}
}