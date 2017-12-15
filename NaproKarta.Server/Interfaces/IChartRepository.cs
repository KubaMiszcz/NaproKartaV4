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
		Chart GetChart(int id);
		int AddChart(Chart chart);
		void UpdateChart(int id);
		void UpdateChart(Chart chart);
		void DeleteChart(int id);
		void DeleteChart(Chart chart);
		IQueryable<Chart> GetUserCharts(string loggedUserId);
	}

}
