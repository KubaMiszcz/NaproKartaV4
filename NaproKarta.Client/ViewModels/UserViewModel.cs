using NaproKarta.Server.Models;
using System.Collections.Generic;

namespace NaproKarta.Client.ViewModels
{
   public class UserViewModel
  {
    public string Name { get; set; }
    public IList<Chart> Charts { get; set; }
  }
}