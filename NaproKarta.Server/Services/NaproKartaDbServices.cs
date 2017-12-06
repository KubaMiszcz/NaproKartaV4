using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Context;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Services
{
   public class NaproKartaDbServices
   {
      public static IList<Chart> GetUserCharts(string userId)
      {
         using (var context = new NaproKartaDbContext())
         {
            return context.Charts.Where(x => x.UserId == userId).ToList();
         }
      }

      public static ApplicationUser GetLoggedUser(string userId)
      {
         using (var context = new NaproKartaDbContext())
         {
            return context.Users.Find(userId);
         }
      }
   }
}