using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using NaproKarta.Server.Context;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Repositories
{
	public class ChartRepository : IChartRepository
	{
		private readonly NaproKartaDbContext _context;

		public ChartRepository() { }

		public ChartRepository(NaproKartaDbContext context)
		{
			_context = context;
		}

		//public HashSet<string[]> GetUserChartIdsAndTitlesHashSet(string loggedUserId)
		//{
		//	HashSet<string[]> result = new HashSet<string[]>();

		//	foreach (var x in GetUserCharts(loggedUserId))
		//	{
		//		result.Add(new string[] { x.Id.ToString(), x.Title });
		//	}

		//	//_context.Charts
		//	// .Where(x => x.UserId == loggedUserId).ToList()
		//	// .ForEach(x => result.Add(new string[] { x.Id.ToString(), x.Title }));

		//	return result;
		//}

		public Chart GetChart(int id)
		{
			return _context.Charts.Find(id);
		}

		public IQueryable<Chart> GetUserCharts(string loggedUserId)
		{
			return _context.Charts.Where(x => x.UserId == loggedUserId);
		}

		public int AddChart(Chart chart)
		{
			_context.Charts.Add(chart);
			_context.SaveChanges();
			return chart.Id;
		}

		public int UpdateChart(Chart newChart)
		{
			var chart = GetChart(newChart.Id);
			_context.Entry(chart).CurrentValues.SetValues(newChart);
			_context.Entry(chart).State = EntityState.Modified;
			_context.SaveChanges();
			return chart.Id;
		}

		public bool DeleteChart(Chart chart)
		{
			_context.Charts.Remove(chart);
			_context.SaveChanges();
			return true;
		}

		//public void UpdateChart(int id)
		//{
		//	throw new NotImplementedException();
		//}

		//public void UpdateChart(Chart chart)
		//{
		//	throw new NotImplementedException();
		//}

		//public void DeleteChart(int id)
		//{
		//	this.DeleteChart(this.GetChart(id));
		//}

		//public void DeleteChart(Chart chart)
		//{
		//	_context.Charts.Remove(chart);
		//	_context.SaveChanges();
		//}

	}
}