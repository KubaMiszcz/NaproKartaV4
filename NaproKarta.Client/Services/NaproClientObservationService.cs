using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using NaproKarta.Client.ViewModels;
using NaproKarta.Server.Context;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.Services
{
   public class NaproClientObservationService
   {
      internal static Observation ObservationVm2ObservationDb(Observation observation, ObservationVm observationVm)
      {
         observation.MarkerId = observationVm.Marker;
         observation.PeakDayNumber = observationVm.PeakDayNumber;
         observation.Date = observationVm.Date;
         observation.Letter = new Letter() { Value = observationVm.Letter };
         observation.IsB = observationVm.IsB;
         observation.NumTimes.Value = observationVm.NumTimes;
         observation.Cipher.Value = observationVm.Cipher;
         observation.CipherCd.Value = observationVm.CipherCd;
         //public int? CommentId { get; set; }
         //public virtual IList<Comment> Comments { get; set; }

         foreach (var item in observationVm.Notes)
         {
            //todo: implemet
         }

         return observation;
      }

      internal static Observation ObservationVm2ObservationDb(ObservationVm observationVm)
      {
         Observation observation = ObservationVm2ObservationDb(new Observation(), observationVm);
         return observation;
      }

   }
}