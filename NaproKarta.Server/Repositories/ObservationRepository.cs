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
   public class ObservationRepository : IObservationRepository
   {
      private readonly NaproKartaDbContext _context;

      public ObservationRepository() { }

      public ObservationRepository(NaproKartaDbContext context)
      {
         _context = context;
      }

      public IQueryable<Observation> GetObservation(int id)
      {
         var result = _context.Observations
            .Include(x => x.Marker)
            .Include(x => x.Letter)
            .Include(x => x.NumTimes)
            .Include(x => x.Cipher)
            .Include(x => x.CipherCd)
            .Include(x => x.Comments)
            .Include(x => x.Notes)
            .Where(x => x.Id == id)
            .AsQueryable();
         return result;
      }

      public IQueryable<string> GetObservationOwnerId(int id)
      {
         var result = _context.Cycles
            .Where(x => x.Id == id)
            .Select(y => y.Chart)
            .Select(y => y.User)
            .Select(y => y.Id)
            .AsQueryable();
         return result;
      }

      public int UpdateObservation(Observation observation)
      {
         _context.Entry(observation).State = EntityState.Modified;
         _context.SaveChanges();
         return observation.Id;
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