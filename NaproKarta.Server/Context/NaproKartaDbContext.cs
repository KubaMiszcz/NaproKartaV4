using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Context
{
  // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
 public class NaproKartaDbContext : IdentityDbContext<ApplicationUser>
  {
    public NaproKartaDbContext()
      : base("DefaultConnection", throwIfV1Schema: false)
    {

    }

    public static NaproKartaDbContext Create()
    {
      return new NaproKartaDbContext();
    }

    public DbSet<Chart> Charts { get; set; }
    public DbSet<Cycle> Cycles { get; set; }
    public DbSet<Observation> Observations { get; set; }

      //protected override void OnModelCreating(DbModelBuilder modelBuilder)
      //{
      //   // Configure Student & StudentAddress entity
      //   modelBuilder.Entity<ApplicationUser>()
      //      .HasOptional(s => s.UserData) // Mark Address property optional in Student entity
      //      .WithRequired(ad => ad.User); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
      //   }

   }
}