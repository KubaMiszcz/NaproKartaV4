using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
//using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NaproKarta.Client.ViewModels;
using NaproKarta.Server.Services;

namespace NaproKarta.Client.ApiControllers
{
   [System.Web.Http.Authorize]
   //[System.Web.Http.AllowAnonymous]
   [System.Web.Http.RoutePrefix("api/App")]
   public class AppController : ApiController
   {
      [System.Web.Http.Route("GetNavBarData")]
      [System.Web.Http.HttpGet]
      public HttpResponseMessage GetNavBarData()
      {
         var loggedUserId = User.Identity.GetUserId();
         var loggedUser = NaproKartaUserService.GetLoggedUser(loggedUserId);

         NavBarViewModel result = new NavBarViewModel();
         result.IsLogged = loggedUserId != null ? true : false;
         if (result.IsLogged)
         {
            result.UserName = loggedUser?.UserName;
            result.ChartIdsAndTitles = NaproKartaChartService.GetUserChartIdsAndTitlesHashSet(loggedUserId);
         }

         return Request.CreateResponse(HttpStatusCode.OK, result);
      }

      #region DefaultActionsIn prebuilt controller webapi

      // GET api/values/5
      public string Get(int id)
      {
         return "value";
      }

      // POST api/values
      public void Post([FromBody] string value)
      {
      }

      // PUT api/values/5
      public void Put(int id, [FromBody] string value)
      {
      }

      // DELETE api/values/5
      public void Delete(int id)
      {
      }

      #endregion
   }
}
