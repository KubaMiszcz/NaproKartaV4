using System.Web;
using System.Web.Mvc;

namespace NaproKarta.Client
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
