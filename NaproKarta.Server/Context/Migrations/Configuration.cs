using NaproKarta.Server.Context;

namespace NaproKarta.Server.Migrations
{
	using NaproKarta.Server.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<NaproKartaDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(NaproKartaDbContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.

			//List<string> lstr = new List<string>() { "red", "green", "yellow", "whitebaby", "greenbaby", "yellowbaby", "grey" };
			//foreach (string item in lstr) { context.Markers.AddOrUpdate(p => p.Id, new Marker() { Id = item}); }

			//lstr = new List<string>() { "M", "H", "L", "VL", "VVL" };
			//foreach (string item in lstr) { context.Letters.AddOrUpdate(p => p.Id, new Letter() { Id = item }); }

			////lstr = new List<string>() { "M", "H", "L", "VL", "VVL" };
			////foreach (string item in lstr) { context.Letters.AddOrUpdate(p => p.Id, new Letter() { Id = item, IsB = false }); }

			////lstr = new List<string>() { "M", "H", "L", "VL", "VVL" };
			////foreach (string item in lstr) { context.Letters.AddOrUpdate(p => p.Id, new Letter() { Id = item, IsB = true }); }

			//lstr = new List<string>() { "X1", "X2", "X3", "AD" };
			//foreach (string item in lstr) { context.NumTimes.AddOrUpdate(p => p.Id, new NumTime() { Id = item }); }

			//lstr = new List<string>() { "0", "2", "2W", "4", "6", "8", "10", "10DL", "10SL", "10WL" };
			//foreach (string item in lstr) { context.Ciphers.AddOrUpdate(p => p.Id, new Cipher() { Id = item }); }

			//lstr = new List<string>() { "B", "C", "C/K", "G", "L", "P", "Y", "\"P\"" };
			//foreach (string item in lstr) { context.CipherCds.AddOrUpdate(p => p.Id, new CipherCd() { Id = item }); }

   //      lstr = new List<string>() { "Badania", "Wizyta", "ILupucupu" };
   //      foreach (string item in lstr) { context.Comments.AddOrUpdate(p => p.Content, new Comment() { Content = item }); }
      }
	}
}
