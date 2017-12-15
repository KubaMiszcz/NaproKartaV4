using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaproKarta.Server.Context;
using NaproKarta.Server.Models;
using NaproKarta.Server.Interfaces;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
//using System.ComponentModel.DataAnnotations.Schema;

namespace NaproKarta.Server.Repositories
{
	public class ApplicationUserRepository : IApplicationUserRepository
	{
		private readonly NaproKartaDbContext _context;

		public ApplicationUserRepository() { }

		public ApplicationUserRepository(NaproKartaDbContext context)
		{
			_context = context;
		}

		public ApplicationUser GetLoggedUser(string loggedUserId)
		{
				return _context.Users.Find(loggedUserId);
		}

	}
}