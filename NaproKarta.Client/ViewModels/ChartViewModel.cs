using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.ViewModels
{
	public class ChartViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Note { get; set; }
		public IList<Cycle> Cycles { get; set; }

		//public ChartViewModel() { }

		//public ChartViewModel(Chart chart)
		//{
		//   this.Title = chart.Title;
		//   this.Note = chart.Note;
		//}
	}
}