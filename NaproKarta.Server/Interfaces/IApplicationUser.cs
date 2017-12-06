using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Interfaces
{
   public interface IApplicationUser 
   {
      IList<Chart> Charts { get; set; }
   }
}
