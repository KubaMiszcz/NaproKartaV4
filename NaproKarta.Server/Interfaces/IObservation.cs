﻿using System.ComponentModel.DataAnnotations;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
   public interface IObservation
   {
      [Key]
      int Id { get; set; }
      int CycleId { get; set; }
      Cycle Cycle { get; set; }
   }
}