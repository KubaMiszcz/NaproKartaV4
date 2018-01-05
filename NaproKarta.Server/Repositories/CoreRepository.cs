using NaproKarta.Server.Context;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaproKarta.Server.Repositories
{
	public class CoreRepository: ICoreRepository
	{
		private readonly NaproKartaDbContext _context;

		public CoreRepository() { }

		public CoreRepository(NaproKartaDbContext context)
		{
			_context = context;
		}

		public IQueryable<Letter> GetLetterValue(int id)
		{
			return _context.Letters.Where(x => x.Id == id);
		}
	}
}

