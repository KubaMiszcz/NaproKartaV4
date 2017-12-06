using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Models
{
   public class Chart : IChart
   {
      [Key]
      public int Id { get; set; }
      //public int UserDataId { get; set; }
      //public virtual UserData UserData { get; set; }      
      public string UserId { get; set; }
      public virtual ApplicationUser User { get; set; }
      public string Title { get; set; }
      public string Note { get; set; }
      public virtual IList<Cycle> Cycles { get; set; }
   }
}