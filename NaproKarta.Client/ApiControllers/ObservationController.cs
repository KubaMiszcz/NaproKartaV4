﻿using System;
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
	[RoutePrefix("api/Observation")]
	public class ObservationController : ApiController
	{
		private readonly IObservationRepository _observationRepository;
		private string loggedUserId;

		public ObservationController()
		{
			loggedUserId = User.Identity.GetUserId();
		}

		public ObservationController(IObservationRepository observationRepository) : this()
		{
			_observationRepository = observationRepository;
		}

		[Route("GetObservation/{id?}")]
		[HttpGet]
		public HttpResponseMessage GetObservation(int id)
		{
			if (loggedUserId == null)
				//TODO: you are not logged message here
				return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

			var observation = _observationRepository.GetObservation(id);

			if (observation == null)
				return Request.CreateResponse(HttpStatusCode.OK, "err Observation nie istenieje");

			//			var result = NaproClientChartService.ChartDb2ChartVm(chart);
			var result = observation;
			return Request.CreateResponse(HttpStatusCode.OK, result);
		}

		//======================================
/*
		//[Route("AddChart")]
		[HttpPost, HttpOptions]
		public HttpResponseMessage AddChart(ChartViewModel chartVm)
		{
			if (NaproClientAppService.HasReqestOPTIONSHeader(Request))
				return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

			if (loggedUserId == null)
				//TODO: you are not logged message here
				return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

			if (!ModelState.IsValid)
				return Request.CreateResponse(HttpStatusCode.BadRequest);

			Chart chart = NaproClientChartService.ChartVm2ChartDb(loggedUserId, chartVm);
			var result = _observationRepository.AddChart(chart);
			//TODO: what if chart with this name already exists??
			return Request.CreateResponse(HttpStatusCode.Created,
			   new string[] { result.ToString(), "success nowa karta dodana" });

		}

		[HttpDelete, HttpOptions]
		public HttpResponseMessage DeleteChart(int id)
		{
			if (NaproClientAppService.HasReqestOPTIONSHeader(Request))
				return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

			if (loggedUserId == null)
				//TODO: you are not logged message here
				return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

			var chart = _observationRepository.GetChart(id);

			if (chart == null)
				return Request.CreateResponse(HttpStatusCode.OK, "err chart nie istenieje");

			if (chart.UserId != loggedUserId)
				return Request.CreateResponse(HttpStatusCode.OK, "err nie twoj chart");

			var result = _observationRepository.DeleteChart(chart);
			//TODO: what if chart with this name already exists??
			return Request.CreateResponse(HttpStatusCode.OK, "success karta usunieta");

		}

		[HttpPut, HttpOptions]
		public HttpResponseMessage ModifyChart(ChartViewModel chartVm)
		{
			if (NaproClientAppService.HasReqestOPTIONSHeader(Request))
				return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

			if (loggedUserId == null)
				//TODO: you are not logged message here
				return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

			if (!ModelState.IsValid)
				return Request.CreateResponse(HttpStatusCode.BadRequest);

			var chart = _observationRepository.GetChart(chartVm.Id);

			if (chart.UserId != loggedUserId)
				return Request.CreateResponse(HttpStatusCode.OK, "err nie twoj chart");

			chart = NaproClientChartService.ChartVm2ChartDb(loggedUserId, chartVm);

			//TODO: what if chart with this name already exists??
			var result = _observationRepository.UpdateChart(chart);
			return Request.CreateResponse(HttpStatusCode.OK,
				new string[] { result.ToString(), "success karta zmieniona" });
		}

	*/
	}
}

