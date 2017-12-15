using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using NaproKarta.Client.Services;
using NaproKarta.Client.ViewModels;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;
using NaproKarta.Server.Context;

namespace NaproKarta.Client.ApiControllers
{
	//[Authorize]
	[AllowAnonymous]
	[RoutePrefix("api/Chart")]
	public class ChartController : ApiController
	{
		private readonly IChartRepository _chartRepository;
		private string loggedUserId;

		public ChartController()
		{
			loggedUserId = User.Identity.GetUserId();
		}

		public ChartController(IChartRepository chartRepository) : this()
		{
			_chartRepository = chartRepository;
		}

		[Route("GetChart/{id?}")]
		[HttpGet]
		public HttpResponseMessage GetChart(int id)
		{
			var chart = _chartRepository.GetChart(id);

			if (chart==null)
				return Request.CreateResponse(HttpStatusCode.OK, "err chart nie istenieje");


			if (chart.UserId!=loggedUserId)
				return Request.CreateResponse(HttpStatusCode.OK, "err nie twoj chart");

			var result = NaproClientChartService.ChartDb2ChartVm(chart);
			return Request.CreateResponse(HttpStatusCode.OK, result);
		}

		[Route("AddChart")]
		[HttpPost, HttpOptions]
		public HttpResponseMessage AddChart(ChartViewModel chartVm)
		{
			if (NaproClientAppService.ReqestHasOPTIONSHeader(Request))
				return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

			if (!ModelState.IsValid)
				return Request.CreateResponse(HttpStatusCode.BadRequest);

			if (loggedUserId == null)
				//TODO: you are not logged message here
				return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

			Chart chart = NaproClientChartService.ChartVm2ChartDb(chartVm);
			chart.UserId = User.Identity.GetUserId();
			var result = _chartRepository.AddChart(chart);
			return Request.CreateResponse(HttpStatusCode.Created,
			   new string[] { result.ToString(), "success nowa karta dodana" });

		}
	}
}

