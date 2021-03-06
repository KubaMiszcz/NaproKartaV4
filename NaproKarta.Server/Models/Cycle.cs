using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;
using Newtonsoft.Json;

namespace NaproKarta.Server.Models
{
   public class Cycle
   {

      [Key]
      public int Id { get; set; }
      public int ChartId { get; set; }
      public virtual Chart Chart { get; set; }
      public int NumberInChart { get; set; }
      public string Note { get; set; }
      public virtual IList<Observation> Observations { get; set; }

      public Cycle() { }

      public Cycle(int parentChartId, int numberOfParentCycleInChart)
      {
         ChartId = parentChartId;
         NumberInChart = numberOfParentCycleInChart;
      }
   }
}