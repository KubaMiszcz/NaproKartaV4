﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Context;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Services
{
  public class NaproKartaChartService
   {
    public static HashSet<string[]> GetUserChartIdsAndTitlesHashSet(string loggedUserId)
    {
      using (var context = new NaproKartaDbContext())
      {
        HashSet<string[]> result = new HashSet<string[]>();
        context.Charts
          .Where(x => x.UserId == loggedUserId).ToList()
          .ForEach(x => result.Add(new string[] { x.Id.ToString(), x.Title }));

        return result;
      }
    }

    public static Chart GetChartById(int? id)
    {
      using (var context = new NaproKartaDbContext())
      {
        return context.Charts.Find(id);
      }
    }
  }
}