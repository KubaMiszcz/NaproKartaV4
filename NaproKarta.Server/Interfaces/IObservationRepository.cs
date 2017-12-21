using System.ComponentModel.DataAnnotations;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
   public interface IObservationRepository
	{
		Observation GetObservation(int id);
   }
}