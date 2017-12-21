using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Context;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Repositories
{
	public class ObservationRepository : IObservationRepository
	{
		private readonly NaproKartaDbContext _context;

		public ObservationRepository() { }

		public ObservationRepository(NaproKartaDbContext context)
		{
			_context = context;
		}

		public Observation GetObservation(int id)
		{
			return _context.Observations.Find(id);
		}





		////===================================================
		//public IQueryable<Chart> GetUserCharts(string loggedUserId)
		//{
		//	return _context.Charts.Where(x => x.UserId == loggedUserId);
		//}

		//public int AddChart(Chart chart)
		//{
		//	_context.Charts.Add(chart);
		//	_context.SaveChanges();
		//	return chart.Id;
		//}

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
		//	//this.DeleteChart(this.GetChart(id));
		//}

		//public void DeleteChart(Chart chart)
		//{
		//	_context.Charts.Remove(chart);
		//	_context.SaveChanges();
		//}

	}
}