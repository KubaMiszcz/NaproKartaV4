using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Context;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Services
{
  public class NaproKartaUserService
  {
    public static ApplicationUser GetLoggedUser(string loggedUserId)
    {
      using (var context = new NaproKartaDbContext())
      {
        return context.Users.Find(loggedUserId);
      }
    }
      
  }
}