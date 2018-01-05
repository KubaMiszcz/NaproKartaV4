using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
	public interface IChartRepository
	{
		IQueryable<Chart> GetChart(int id);
		int AddChart(Chart chart);
		IQueryable<Chart> GetUserCharts(string loggedUserId);
		int UpdateChart(Chart chart);
		bool DeleteChart(Chart chart);

		//HashSet<string[]> GetUserChartIdsAndTitlesHashSet(string loggedUserId);
		//void UpdateChart(int id);
		//void UpdateChart(Chart chart);
		//void DeleteChart(Chart chart);
		//IQueryable<Chart> GetUserCharts(string loggedUserId);
	}
}
