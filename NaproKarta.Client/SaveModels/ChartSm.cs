using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.SaveModels
{
	public class ChartSm
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Note { get; set; }

		public ChartSm() { }

		public ChartSm(Chart chart)
		{
			//Id = chart.Id;
			//Title = chart.Title;
			//Note = chart.Note;
			//Cycles = new List<CycleVm>();
			//foreach (var item in chart.Cycles)
			//{
			//	Cycles.Add(new CycleVm(item));
			//}
		}
	}
}