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
using NaproKarta.Client.ViewModels;
using NaproKarta.Server.Services;

namespace NaproKarta.Client.ApiControllers
{
   [System.Web.Http.Authorize]
   //[System.Web.Http.AllowAnonymous]
   [System.Web.Http.RoutePrefix("api/Chart")]
   public class ChartController : ApiController
   {

      [System.Web.Http.Route("GetChartById/{id}")]
      [System.Web.Http.HttpGet]
      public HttpResponseMessage GetChartById(int? id)
      {
         var chart = NaproKartaChartService.GetChartById(id);

         ChartViewModel result = new ChartViewModel();
         if (chart != null)
         {
            result.Title = chart.Title;
            result.Note = chart.Note;
         }

         return Request.CreateResponse(HttpStatusCode.OK, result);
      }


   }
}
