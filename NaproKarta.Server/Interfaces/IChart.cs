using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
   public interface IChart
   {
      [Key]
      int Id { get; set; }
      int UserDataId { get; set; }
      UserData UserData { get; set; }
      string Name { get; set; }
      string Title { get; set; }
      IList<Cycle> Cycles { get; set; }
   }
}
