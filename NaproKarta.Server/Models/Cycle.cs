using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Models
{
   public class Cycle
   {
      [Key]
      public int Id { get; set; }
      public int ChartId { get; set; }
      public virtual Chart Chart { get; set; }
      public string NumberInChart { get; set; }
      public string Note { get; set; }
      public virtual IList<Observation> Observations { get; set; }
   }
}