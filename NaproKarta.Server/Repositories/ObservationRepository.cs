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

      public IQueryable<string> GetObservationOwnerId(int obsId)
      {
         var result = _context.Users
            .Join(_context.Charts, p => p.Id, p => p.UserId, (x, y) => new { User = x, Chart = y })
            .Join(_context.Cycles, p => p.Chart.Id, p => p.ChartId, (x, y) => new { x.User, x.Chart, Cycle = y })
            .Join(_context.Observations, p => p.Cycle.Id, p => p.CycleId, (x, y) => new { x.User, x.Chart, x.Cycle, Observation = y })
            .Where(p => p.Observation.Id == obsId)
            .Select(p => p.User.Id)
            .AsQueryable();

         return result;
      }

      public int UpdateObservation(Observation observation)
      {
         _context.Entry(observation).State = EntityState.Modified;
         _context.SaveChanges();
         return observation.Id;
      }

      public bool DeleteObservation(int id)
      {
         _context.Observations.Remove(_context.Observations.Find(id));
         _context.SaveChanges();
         return true;
      }

      public int AddObservation(Observation observation)
      {
         _context.Observations.Add(observation);
         _context.SaveChanges();
         return observation.Id;
      }

      public int UpdateCycleId(int parentChartId, int numberOfParentCycleInChart)
      {
         var result = _context.Cycles.Where(x => (x.ChartId == parentChartId) && (x.NumberInChart == numberOfParentCycleInChart)).FirstOrDefault();
         if (result == null)
         {
            result = new Cycle(parentChartId, numberOfParentCycleInChart);
            _context.Cycles.Add(result);
            _context.SaveChanges();
            return result.Id;
         }
         else
         {
            return result.Id;
         }
      }

      public IQueryable<Marker> GetMarkerByValue(string val)
      {
         return _context.Markers.Where(x => x.Id == val).AsQueryable();
      }
      public IQueryable<Letter> GetLetterByValue(string val)
      {
         return _context.Letters.Where(x => x.Value == val).AsQueryable();
      }
      public IQueryable<Cipher> GetCipherByValue(string val)
      {
         return _context.Ciphers.Where(x => x.Value == val).AsQueryable();
      }
      public IQueryable<CipherCd> GetCipherCdByValue(string val)
      {
         return _context.CipherCds.Where(x => x.Value == val).AsQueryable();
      }
      public IQueryable<NumTimes> GetNumTimesByValue(string val)
      {
         return _context.NumTimes.Where(x => x.Value == val).AsQueryable();
      }

   }
}