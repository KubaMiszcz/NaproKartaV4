using NaproKarta.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaproKarta.Client.ViewModels
{
	public class CycleVm
	{
		public int Id { get; set; }
		public int ChartId { get; set; }
		public string NumberInChart { get; set; }
		public string Note { get; set; }
		public IList<ObservationVm> Observations { get; set; }

		public CycleVm() { }

		public CycleVm(Cycle cycle)
		{
			Id = cycle.Id;
			ChartId = cycle.ChartId;
			NumberInChart = cycle.NumberInChart;
			Note = cycle.Note;
			Observations = new List<ObservationVm>();
			foreach (var item in cycle.Observations)
			{
            Observations.Add(new ObservationVm(item));
         }
		}
	}
}