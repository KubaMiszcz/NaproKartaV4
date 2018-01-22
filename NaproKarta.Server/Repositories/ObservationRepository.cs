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
   }
}