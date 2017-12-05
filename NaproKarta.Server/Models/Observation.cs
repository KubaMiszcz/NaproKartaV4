using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using NaproKarta.Server.Interfaces;

namespace NaproKarta.Server.Models
{
   public class Observation : IObservation
   {
      [Key]
      public int Id { get; set; }
      public int CycleId { get; set; }
      public virtual Cycle Cycle { get; set; }
   }
}