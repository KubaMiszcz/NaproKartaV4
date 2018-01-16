using System.ComponentModel.DataAnnotations;
using System.Linq;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
   public interface IObservationRepository
	{
      IQueryable<Observation> GetObservation(int id);
      object UpdateObservation(Observation observation);
   }
}