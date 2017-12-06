using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NaproKarta.Server.Models
{
   public class Class1
   {
      [Key]
      public int Id { get; set; }
      public string Name { get; set; }
      public virtual ApplicationUser User { get; set; }
   }
}