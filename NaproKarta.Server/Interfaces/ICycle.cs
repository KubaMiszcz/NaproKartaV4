using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
   public interface ICycle
   {
      [Key]
      int Id { get; set; }
      int ChartId { get; set; }
      IChart Chart { get; set; }
      string NumberInChart { get; set; }
      string Note { get; set; }
      IList<Observation> Observations { get; set; }
   }
}