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
using NaproKarta.Client.Models.ViewModels;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;
using NaproKarta.Server.Context;
using Newtonsoft.Json;
using NaproKarta.Client.Interfaces;
using NaproKarta.Client.Repositories;

namespace NaproKarta.Client.ApiControllers
{
   //[Authorize]
   [AllowAnonymous]
   [RoutePrefix("api/Chart")]
   public class ChartController : ApiController
   {
      private readonly IChartRepository _chartRepository;
      private readonly IChartVmRepository _chartVmRepository;
      private string loggedUserId;

      public ChartController()
      {
         loggedUserId = User.Identity.GetUserId();
      }

      public ChartController(IChartRepository chartRepository) : this()
      {
         _chartRepository = chartRepository;
         _chartVmRepository = new ChartVmRepository(_chartRepository);
      }

      [Route("GetChart/{id?}")]
      [HttpGet]
      public HttpResponseMessage GetChart(int id)
      {
         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         var chart = _chartRepository.GetChart(id).FirstOrDefault();

         if (chart == null)
            return Request.CreateResponse(HttpStatusCode.OK, "err chart nie istenieje");

         if (chart.UserId != loggedUserId)
            return Request.CreateResponse(HttpStatusCode.OK, "err nie twoj chart");

         var result = new ChartVm(chart);
         return Request.CreateResponse(HttpStatusCode.OK, result);
      }

      //[Route("AddChart")]
      [HttpPost, HttpOptions]
      public HttpResponseMessage AddChart(ChartVm chartVm)
      {
         if (Request.Method == HttpMethod.Options)
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         if (!ModelState.IsValid)
            return Request.CreateResponse(HttpStatusCode.BadRequest);

         Chart chart = _chartVmRepository.CreateNewChartFromChartVm(loggedUserId, chartVm);
         var result = _chartRepository.AddChart(chart);
         //TODO: what if chart with this name already exists??
         return Request.CreateResponse(HttpStatusCode.Created,
            new string[] { result.ToString(), "success nowa karta dodana" });

      }

      [HttpDelete, HttpOptions]
      public HttpResponseMessage DeleteChart(int id)
      {
         if (Request.Method == HttpMethod.Options)
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         var chartUserId = _chartRepository.GetChart(id).Select(x => x.UserId).FirstOrDefault();

         if (chartUserId == null)
            return Request.CreateResponse(HttpStatusCode.OK, "err chart nie istenieje");

         if (chartUserId != loggedUserId)
            return Request.CreateResponse(HttpStatusCode.OK, "err nie twoj chart");

         var result = _chartRepository.DeleteChart(id);
         //TODO: what if chart with this name already exists??
         return Request.CreateResponse(HttpStatusCode.OK, "success karta usunieta");
      }

      [HttpPut, HttpOptions]
      public HttpResponseMessage UpdateChart(ChartVm chartVm)
      {
         if (Request.Method == HttpMethod.Options)
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };


         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         if (!ModelState.IsValid)
            return Request.CreateResponse(HttpStatusCode.BadRequest);

         var chartQuery = _chartRepository.GetChart(chartVm.Id);
         var chartUserId = chartQuery.Select(x => x.UserId).FirstOrDefault();

         if (chartUserId != loggedUserId)
            return Request.CreateResponse(HttpStatusCode.OK, "err nie twoj chart");

         var chart = _chartVmRepository.UpdateChartFromChartVm(chartQuery.FirstOrDefault(), chartVm);

         //TODO: what if chart with this name already exists??
         var result = _chartRepository.UpdateChart(chart);
         return Request.CreateResponse(HttpStatusCode.OK,
            new string[] { result.ToString(), "success dane karty zmienione" });
      }
   }
}


