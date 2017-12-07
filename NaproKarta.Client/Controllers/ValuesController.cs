using System.Collections.Generic;
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

namespace NaproKarta.Client.Controllers
{
  [System.Web.Http.Authorize]
  //[System.Web.Http.AllowAnonymous]
  [System.Web.Http.RoutePrefix("api/Values")]
   public class ValuesController : ApiController
   {
    // GET api/values
    [System.Web.Http.Route("Gettt")]
      [System.Web.Http.HttpGet]
      public IEnumerable<string> Get()
      {
         return new string[] { "value1", "value2" };
      }

      [System.Web.Http.Route("GetStr")]
      [System.Web.Http.HttpGet]
      public string GetStr()
      {
         string str = "string111111";
         return str;
      }

      [System.Web.Http.Route("GetLoggedUser")]
      [System.Web.Http.HttpGet]
      public HttpResponseMessage GetLoggedUser()
      {
         var loggedUserId = User.Identity.GetUserId();
         var loggedUser = NaproKartaDbServices.GetLoggedUser(loggedUserId);

         UserViewModel result= new UserViewModel()
         {
            Name = loggedUser?.UserName
         };
        return Request.CreateResponse(HttpStatusCode.OK, result);
      }


      // GET api/values/5
      public string Get(int id)
      {
         return "value";
      }

      // POST api/values
      public void Post([FromBody]string value)
      {
      }

      // PUT api/values/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE api/values/5
      public void Delete(int id)
      {
      }
   }
}
