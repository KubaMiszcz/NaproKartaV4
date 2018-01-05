using NaproKarta.Server.Context;
using NaproKarta.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaproKarta.Server.Interfaces
{
	public interface ICoreRepository
	{
		IQueryable<Letter> GetLetterValue(int id);
	}
}

