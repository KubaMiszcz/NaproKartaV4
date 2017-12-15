using NaproKarta.Server.Models;
using System.Collections.Generic;

namespace NaproKarta.Client.ViewModels
{
	public class ChartIdAndTitle
	{
		public int ChartId { get; set; }
		public string ChartTitle { get; set; }

		public ChartIdAndTitle() { }

		public ChartIdAndTitle(int id, string title)
		{
			this.ChartId = id;
			this.ChartTitle = title;
		}
	}
}