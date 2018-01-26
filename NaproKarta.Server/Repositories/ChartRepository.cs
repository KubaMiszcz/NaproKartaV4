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

		public IQueryable<Chart> GetChart(int id)
		{
         var result = _context.Charts.Where(x => x.Id == id)
				.Include(c => c.Cycles.Select(o => o.Observations.Select(i => i.Letter)))
				.Include(c => c.Cycles.Select(o => o.Observations.Select(i => i.Cipher)))
				.Include(c => c.Cycles.Select(o => o.Observations.Select(i => i.CipherCd)))
				.Include(c => c.Cycles.Select(o => o.Observations.Select(i => i.NumTimes)))
				.Include(c => c.Cycles.Select(o => o.Observations.Select(i => i.Comments)))
				.Include(c => c.Cycles.Select(o => o.Observations.Select(i => i.Notes)))
				.AsQueryable();

			return result;
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

		public int UpdateChart(Chart chart)
		{
         _context.Entry(chart).State = EntityState.Modified;
         _context.SaveChanges();
         return chart.Id;
      }

      public bool DeleteChart(int id)
		{
			_context.Charts.Remove(_context.Charts.Find(id));
			_context.SaveChanges();
			return true;
		}
	}
}
