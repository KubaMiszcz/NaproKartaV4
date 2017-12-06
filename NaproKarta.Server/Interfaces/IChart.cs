﻿using System;
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
      string UserId { get; set; }
      ApplicationUser User { get; set; }
      string Title { get; set; }
      string Note { get; set; }
      IList<Cycle> Cycles { get; set; }
   }
}
