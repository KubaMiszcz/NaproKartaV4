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
      internal static Chart ChartVm2ChartDb(Chart chart, ChartVm chartVm)
      {
         chart.Title = chartVm.Title;
         chart.Note = chartVm.Note;
         return chart;
      }

      internal static Chart ChartVm2ChartDb(string loggedUserId, ChartVm chartVm)
      {
         var result = ChartVm2ChartDb(new Chart(), chartVm);
         result.UserId = loggedUserId;
         return result;
      }

   }
}