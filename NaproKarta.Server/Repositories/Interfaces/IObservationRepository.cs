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

      IQueryable<Marker> GetMarkerByValue(string id);
      IQueryable<Letter> GetLetterByValue(string val);
      IQueryable<Cipher> GetCipherByValue(string val);
      IQueryable<CipherCd> GetCipherCdByValue(string val);
      IQueryable<NumTimes> GetNumTimesByValue(string val);
      int UpdateCycleId(int parentChartId, int numberOfParentCycleInChart);
      int UpdateNote(ObservationNote note);
      int AddNote(ObservationNote note);
      bool DeleteNote(ObservationNote note);
   }
}