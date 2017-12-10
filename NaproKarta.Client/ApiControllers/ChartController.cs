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
using NaproKarta.Server.Services;

namespace NaproKarta.Client.ApiControllers
{
   //[Authorize]
   [AllowAnonymous]
   [RoutePrefix("api/Chart")]
   public class ChartController : ApiController
   {

      [Route("GetChartById/{id}")]
      [HttpGet]
      public HttpResponseMessage GetChartById(int? id)
      {
         if (id == null)
            return Request.CreateResponse(HttpStatusCode.BadRequest);

         var chart = NaproServerChartService.GetChartById(id);
         var result = NaproClientChartService.ChartDb2ChartVm(chart);
         return Request.CreateResponse(HttpStatusCode.OK, result);
      }

      [Route("AddNewChart")]
      [HttpPost, HttpOptions]
      public HttpResponseMessage AddNewChart(ChartViewModel chartVm)
      {
         if (NaproClientChartService.ReqestHasOPTIONSHeader(Request))
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

         if (!ModelState.IsValid)
            return Request.CreateResponse(HttpStatusCode.BadRequest);

         if (User.Identity.GetUserId() == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.OK, "niezalogowany");

         Chart chartToAdd = NaproClientChartService.ChartVm2ChartDb(chartVm);
         chartToAdd.UserId = User.Identity.GetUserId();
         var result = NaproServerChartService.AddNewChart(chartToAdd);
         return Request.CreateResponse(HttpStatusCode.OK,
            new string[] { result.ToString(), "nowa karta dodana" });

      }
   }
}

