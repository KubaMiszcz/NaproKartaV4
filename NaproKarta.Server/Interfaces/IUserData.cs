using System;
using NaproKarta.Server.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaproKarta.Server.Models
{
   public interface IUserData
   {
      [Key]
      int Id { get; set; }

      string UserId { get; set; }
      ApplicationUser User { get; set; }

      string Name { get; set; }

      [DataType(DataType.EmailAddress)]
      string Email { get; set; }

      [DataType(DataType.Date)]
      DateTime RegisterDate { get; set; }

      [DataType(DataType.Date)]
      DateTime LastLoginDate { get; set; }

      string Note { get; set; }

      IList<Chart> Charts { get; set; }
   }
}

