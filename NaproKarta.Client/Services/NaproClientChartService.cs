using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using NaproKarta.Client.ViewModels;
using NaproKarta.Server.Context;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.Services
{
   public class NaproClientChartService
   {
      public static ChartViewModel ChartDb2ChartVm(Chart chart)
      {
         return new ChartViewModel()
         {
            Title = chart.Title,
            Note = chart.Note
         };
      }

      public static Chart ChartVm2ChartDb(ChartViewModel chartVm)
      {
         return new Chart()
         {
           Title = chartVm.Title,
           Note = chartVm.Note
         };
      }

      public static bool ReqestHasOPTIONSHeader(HttpRequestMessage request)
      {
         //if (Request.Headers.Contains("Origin",StringComparer.CurrentCultureIgnoreCase)
         ////    && Request.Method == HttpMethod.Options)
         //{
         //   Options();
         //}
         return request.Method == HttpMethod.Options ? true:false;
      }
   }
}