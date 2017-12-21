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
				Id = chart.Id,
				Title = chart.Title,
				Note = chart.Note,
				Cycles = chart.Cycles
			};
		}

		public static Chart ChartVm2ChartDb(string loggedUserId, ChartViewModel chartVm)
		{
			return new Chart()
			{
				Id = chartVm.Id,
				UserId = loggedUserId,
				Title = chartVm.Title,
				Note = chartVm.Note,
				Cycles = chartVm.Cycles
			};
		}
	}
}