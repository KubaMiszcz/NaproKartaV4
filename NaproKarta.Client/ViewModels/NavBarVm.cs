using NaproKarta.Server.Models;
using System.Collections.Generic;
using System.Linq;

namespace NaproKarta.Client.ViewModels
{
	public class NavBarVm
	{
		public string UserName { get; set; }
		public IList<ChartIdAndTitle> ChartIdsAndTitles { get; set; }

		public NavBarVm() { }

		public NavBarVm(ApplicationUser loggedUser, IQueryable<Chart> charts)
		{
			UserName = loggedUser?.UserName;
			ChartIdsAndTitles = new List<ChartIdAndTitle>();
			foreach (var item in charts)
			{
				ChartIdsAndTitles.Add(new ChartIdAndTitle(item.Id, item.Title));
			}
		}
	}
}