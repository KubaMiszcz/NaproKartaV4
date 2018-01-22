using System.ComponentModel.DataAnnotations;
using System.Linq;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
   public interface IObservationRepository
	{
      IQueryable<Observation> GetObservation(int id);
      int UpdateObservation(Observation observation);
      IQueryable<string> GetObservationOwnerId(int id);
      bool DeleteObservation(int id);
      int AddObservation(Observation observation);
   }
}