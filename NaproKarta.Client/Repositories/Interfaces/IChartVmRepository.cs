﻿using NaproKarta.Client.Models;
using NaproKarta.Client.Models.ViewModels;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NaproKarta.Client.Interfaces
{
   public interface IChartVmRepository
   {
      Chart UpdateChartFromChartVm(Chart chart, ChartVm chartVm);
      Chart CreateNewChartFromChartVm(string loggedUserId, ChartVm chartVm);
   }
}