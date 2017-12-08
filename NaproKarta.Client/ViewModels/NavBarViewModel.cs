using NaproKarta.Server.Models;
using System.Collections.Generic;

namespace NaproKarta.Client.ViewModels
{
   public class NavBarViewModel
  {
    public string UserName { get; set; }
    public IList<string> ChartTitles { get; set; } = new List<string>();
    public IList<int> ChartIds { get; set; } = new List<int>();
    public HashSet<string[]> ChartIdsAndTitles { get; set; }
    public bool IsLogged { get; set; }
  }
}