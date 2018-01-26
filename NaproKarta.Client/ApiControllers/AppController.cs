using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
//using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NaproKarta.Client.Models.ViewModels;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Repositories;

namespace NaproKarta.Client.ApiControllers
{
	//[System.Web.Http.Authorize]
	[System.Web.Http.AllowAnonymous]
	[System.Web.Http.RoutePrefix("api/App")]
	public class AppController : ApiController
	{
		private readonly IChartRepository _chartRepository;
		private readonly IApplicationUserRepository _applicationUserRepository;
		private string loggedUserId;

		public AppController()
		{
			loggedUserId = User.Identity.GetUserId();
		}

		public AppController(IChartRepository chartRepository, IApplicationUserRepository applicationUserRepository) : this()
		{
			_chartRepository = chartRepository;
			_applicationUserRepository = applicationUserRepository;
		}

		[System.Web.Http.Route("GetNavBarData")]
		[System.Web.Http.HttpGet]
		public HttpResponseMessage GetNavBarData()
		{
			if (loggedUserId == null)
				return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogoany");


			var loggedUser = _applicationUserRepository.GetLoggedUser(loggedUserId);
			var charts = _chartRepository.GetUserCharts(loggedUserId);
			var result = new NavBarVm(loggedUser, charts);
			return Request.CreateResponse(HttpStatusCode.OK, result);
		}

		#region DefaultActionsIn prebuilt controller webapi

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}

		#endregion
	}
}
