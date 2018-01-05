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
		//public static ChartVm ChartDb2ChartVm(Chart chart)
		//{
		//	return new ChartVm()
		//	{
		//		Id = chart.Id,
		//		Title = chart.Title,
		//		Note = chart.Note,
		//		Cycles = chart.Cycles
		//	};
		//}

		//refactor to save model
		public static Chart ChartVm2ChartDb(string loggedUserId, ChartVm chartVm)
		{
			var result = new Chart()
			{
				Id = chartVm.Id,
				UserId = loggedUserId,
				Title = chartVm.Title,
				Note = chartVm.Note,
			};

			//result.Cycles = new List<Cycle>();
			//foreach (var item in chartVm.Cycles)
			//{
			//	Cycle cycle = new Cycle()
			//	{
			//		Id = item.Id,
			//		ChartId = item.ChartId,
			//		Note = item.Note,
			//		NumberInChart=item.NumberInChart,
			//	};
			//	cycle.Observations
			//}
			return result;
		}
	}
}