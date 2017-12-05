using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NaproKarta.Server.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaproKarta.Server.Models
{
  // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
  public class ApplicationUser : IdentityUser
  {
    //public int UserDataId { get; set; }
    //[ForeignKey("UserDataId")]
    //public virtual IList<UserData> ListUserDatas { get; set; }
   public virtual IList<Chart> Charts { get; set; }

    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
    {
      // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
      var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
      // Add custom user claims here
      return userIdentity;
    }
  }

  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext()
      : base("DefaultConnection", throwIfV1Schema: false)
    {

    }

    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }

    //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<UserData> UserDatas { get; set; }
    public DbSet<Chart> Charts { get; set; }
    public DbSet<Cycle> Cycles { get; set; }

    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //   // Configure Student & StudentAddress entity
    //   modelBuilder.Entity<ApplicationUser>()
    //      .HasOptional(s => s.UserData) // Mark Address property optional in Student entity
    //      .WithRequired(ad => ad.User); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
    //   }

  }
}