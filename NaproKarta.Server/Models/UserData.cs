using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Models
{
  public class UserData : IUserData
  {
    [Key]
    public int Id { get; set; }

    public string UserId { get; set; }
    //[ForeignKey("UserId")]
    public virtual ApplicationUser User { get; set; }

    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime RegisterDate { get; set; }
    public DateTime LastLoginDate { get; set; }
    public string Note { get; set; }
    public virtual IList<Chart> Charts { get; set; }

    public UserData(ApplicationUser user)
    {
      UserId = user.Id;
      User = user;
      Name = "nameee"+user.UserName;
      Email = "mail"+user.Email;
      RegisterDate = DateTime.Now;
      LastLoginDate = DateTime.Now;
      Note = "noteee";
      Charts = new List<Chart>();
    }
  }
}