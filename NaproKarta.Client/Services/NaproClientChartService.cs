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
      internal static Chart ChartVm2ChartDb(ChartVm chartVm)
      {
         var result = new Chart()
         {
            Id = chartVm.Id,
            Title = chartVm.Title,
            Note = chartVm.Note,
         };
         return result;
      }

      internal static Chart ChartVm2ChartDb(string loggedUserId, ChartVm chartVm)
      {
         var result = ChartVm2ChartDb(chartVm);
         result.UserId = loggedUserId;
         return result;
      }

   }
}