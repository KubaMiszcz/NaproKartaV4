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

namespace NaproKarta.Client.Controllers
{
  [System.Web.Http.Authorize]
  //[System.Web.Http.AllowAnonymous]
  [System.Web.Http.RoutePrefix("api/Values")]
  public class ValuesController : ApiController
  {
    [System.Web.Http.Route("GetNavBarData")]
    [System.Web.Http.HttpGet]
    public HttpResponseMessage GetNavBarData()
    {
      var loggedUserId = User.Identity.GetUserId();
      var loggedUser = NaproKartaDbServices.GetLoggedUser(loggedUserId);

      NavBarViewModel result = new NavBarViewModel();
      result.IsLogged = loggedUserId != null ? true : false;
      if (result.IsLogged)
      {
        result.UserName = loggedUser?.UserName;
        result.ChartIdsAndTitles = NaproKartaDbServices.GetUserChartIdsAndTitlesHashSet(loggedUserId);
      }

      return Request.CreateResponse(HttpStatusCode.OK, result);
    }


    [System.Web.Http.Route("GetChartById/{id}")]
    [System.Web.Http.HttpGet]
    public HttpResponseMessage GetChartById(int? id)
    {
      var chart = NaproKartaDbServices.GetChartById(id);

      ChartViewModel result = new ChartViewModel();
      if (chart != null)
      {
        result.Title = chart.Title;
        result.Note = chart.Note;
      }

      return Request.CreateResponse(HttpStatusCode.OK, result);
    }






    //=============//=============//=============//=============//=============//=============//=============//=============
    //=============//=============//=============//=============//=============//=============//=============//=============
    //=============//=============//=============//=============//=============//=============//=============//=============

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
