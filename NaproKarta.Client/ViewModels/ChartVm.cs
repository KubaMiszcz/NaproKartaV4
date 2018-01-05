using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.ViewModels
{
	public class ChartVm
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Note { get; set; }
		public IList<CycleVm> Cycles { get; set; }

		public ChartVm() { }

		public ChartVm(Chart chart)
		{
			Id = chart.Id;
			Title = chart.Title;
			Note = chart.Note;
			Cycles = new List<CycleVm>();
			foreach (var item in chart.Cycles)
			{
				Cycles.Add(new CycleVm(item));
			}
		}

		public ChartVm(string loggedUserId, ChartVm chartVm)
		{
		}
	}
}