using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using NaproKarta.Client.Interfaces;
using NaproKarta.Client.Models.ViewModels;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.Repositories
{
   public class ObservationVmRepository : IObservationVmRepository
   {
      private readonly IObservationRepository _observationRepository;

      public ObservationVmRepository() { }

      public ObservationVmRepository(IObservationRepository observationRepository)
      {
         _observationRepository = observationRepository;
      }

      public Observation UpdateObservationDbFromObservationVm(Observation observation, ObservationVm observationVm)
      {
         observation.CycleId = _observationRepository.UpdateCycleId(observationVm.ParentChartId, observationVm.NumberOfParentCycleInChart);
         observation.NumberInCycle = observationVm.NumberInCycle;
         observation.Marker = _observationRepository.GetMarkerByValue(observationVm.Marker).FirstOrDefault();
         observation.PeakDayNumber = observationVm.PeakDayNumber;
         observation.Date = observationVm.Date;
         observation.Letter = _observationRepository.GetLetterByValue(observationVm.Letter).FirstOrDefault();
         observation.IsB = observationVm.IsB;
         observation.NumTimes = _observationRepository.GetNumTimesByValue(observationVm.NumTimes).FirstOrDefault();
         observation.Cipher = _observationRepository.GetCipherByValue(observationVm.Cipher).FirstOrDefault();
         observation.CipherCd = _observationRepository.GetCipherCdByValue(observationVm.CipherCd).FirstOrDefault();
         //comments. notes, pictures
         //public int? CommentId { get; set; }
         //public virtual IList<Comment> Comments { get; set; }

         //foreach (var item in observationVm.Notes)
         //{
         //   //todo: implemet
         //}

         return observation;
      }

      public Observation CreateNewObservationFromObservationVm(ObservationVm observationVm)
      {
         Observation observation = UpdateObservationDbFromObservationVm(new Observation(), observationVm);
         return observation;
      }
   }
}