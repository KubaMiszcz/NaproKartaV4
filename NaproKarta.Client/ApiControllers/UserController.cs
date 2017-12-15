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
using NaproKarta.Server.Context;

namespace NaproKarta.Client.ApiControllers
{
	//[System.Web.Http.Authorize]
	[System.Web.Http.AllowAnonymous]
	[System.Web.Http.RoutePrefix("api/User")]
	public class UserController : ApiController
	{
		public UserController() { }
	}
}
