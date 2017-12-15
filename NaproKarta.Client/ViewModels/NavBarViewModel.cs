using NaproKarta.Server.Models;
using System.Collections.Generic;
using System.Linq;

namespace NaproKarta.Client.ViewModels
{
	public class NavBarViewModel
	{
		public string UserName { get; set; }
		//public IList<string> ChartTitles { get; set; } = new List<string>();
		//public IList<int> ChartIds { get; set; } = new List<int>();
		public IList<ChartIdAndTitle> ChartIdsAndTitles { get; set; }
		public bool IsLogged { get; set; }

		public NavBarViewModel() { }
		
		public NavBarViewModel(ApplicationUser loggedUser, IQueryable<Chart> charts)
		{
			IsLogged = loggedUser.Id != null ? true : false;
			if (IsLogged)
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
}