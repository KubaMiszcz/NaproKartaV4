using NaproKarta.Server.Models;
using System.Collections.Generic;

namespace NaproKarta.Client.ViewModels
{
	public class ChartIdAndTitle
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public ChartIdAndTitle() { }

		public ChartIdAndTitle(int id, string title)
		{
			Id = id;
			Title = title;
		}
	}
}