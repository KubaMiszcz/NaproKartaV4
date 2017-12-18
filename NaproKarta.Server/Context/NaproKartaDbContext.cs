using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using NaproKarta.Server.Models;

/*
   Enable-Migrations -force -verbose
   Add-Migration 1
   Update-Database -Verbose -ProjectName NaproKarta.Server -StartUpProjectName NaproKarta.Server
   */


namespace NaproKarta.Server.Context
{
	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
	public class NaproKartaDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Chart> Charts { get; set; }
		public DbSet<Cycle> Cycles { get; set; }
		public DbSet<Observation> Observations { get; set; }

		public DbSet<Marker> Markers { get; set; }
		public DbSet<Letter> Letters { get; set; }
		public DbSet<NumTime> NumTimes { get; set; }
		public DbSet<Cipher> Ciphers { get; set; }
		public DbSet<CipherCd> CipherCds { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<ObservationNote> ObservationNotes { get; set; }



		public NaproKartaDbContext()
		: base("DefaultConnection", throwIfV1Schema: false)
		{
			this.Configuration.LazyLoadingEnabled = false;
			this.Configuration.ProxyCreationEnabled = false;
		}

		public static NaproKartaDbContext Create()
		{
			return new NaproKartaDbContext();
		}


		//protected override void OnModelCreating(DbModelBuilder modelBuilder)
		//{
		//   // Configure Student & StudentAddress entity
		//   modelBuilder.Entity<ApplicationUser>()
		//      .HasOptional(s => s.UserData) // Mark Address property optional in Student entity
		//      .WithRequired(ad => ad.User); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
		//   }

	}
}