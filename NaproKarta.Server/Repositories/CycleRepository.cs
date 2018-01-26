using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using NaproKarta.Server.Context;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Repositories
{
   public class CycleRepository : ICycleRepository
   {
      private readonly NaproKartaDbContext _context;

      public CycleRepository() { }

      public CycleRepository(NaproKartaDbContext context)
      {
         _context = context;
      }

   }
}
