using NaproKarta.Server.Models;
using System;
using System.Collections.Generic;

namespace NaproKarta.Client.ViewModels
{
   public class ObservationVm
   {
      public int Id { get; set; }
      public int CycleId { get; set; }
      public int NumberInCycle { get; set; }
      public string Marker { get; set; }
      public int? PeakDayNumber { get; set; }
      public DateTime Date { get; set; }
      public string Letter { get; set; }
      public bool IsB { get; set; }
      public string NumTimes { get; set; }
      public string Cipher { get; set; }
      public string CipherCd { get; set; }
      public IList<string> Comments { get; set; }
      public IList<ObservationNoteVm> Notes { get; set; }
      public IList<PictureVm> Pictures { get; set; }

      public ObservationVm() { }

      public ObservationVm(Observation observation)
      {
         Id = observation.Id;
         CycleId = observation.CycleId;
         NumberInCycle = observation.NumberInCycle;
         Marker = observation.MarkerId;
         PeakDayNumber = observation.PeakDayNumber;
         Date = observation.Date;
         Letter = observation.Letter?.Value;
         IsB = observation.IsB;
         NumTimes = observation.NumTimes.Value;
         Cipher = observation.Cipher.Value;
         CipherCd = observation.CipherCd.Value;

         //Comments = new List<string>();
         //foreach (var item in observation.Comments)
         //{
         //   Comments.Add(item.Content);
         //}

         Notes = new List<ObservationNoteVm>();
         foreach (var item in observation?.Notes)
         {
            Notes.Add(new ObservationNoteVm(item));
         }

         //Pictures= new List<PictureVm>();
         //foreach (var item in observation?.Pictures)
         //{
         //   Pictures.Add(new PictureVm(item));
         //}

      }
   }
}