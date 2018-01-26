using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using NaproKarta.Client.Interfaces;
using NaproKarta.Client.Models.ViewModels;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.Repositories
{
   public class ChartVmRepository : IChartVmRepository
   {
      private readonly IChartRepository _chartRepository;

      public ChartVmRepository() { }

      public ChartVmRepository(IChartRepository chartRepository)
      {
         _chartRepository = chartRepository;
      }

      public Chart UpdateChartFromChartVm(Chart chart, ChartVm chartVm)
      {
         chart.Title = chartVm.Title;
         chart.Note = chartVm.Note;
         return chart;
      }

      public Chart CreateNewChartFromChartVm(string loggedUserId, ChartVm chartVm)
      {
         var result = UpdateChartFromChartVm(new Chart(), chartVm);
         result.UserId = loggedUserId;
         return result;
      }
   }
}