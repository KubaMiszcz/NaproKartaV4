using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using NaproKarta.Client.Services;
using NaproKarta.Client.ViewModels;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;
using NaproKarta.Server.Context;

namespace NaproKarta.Client.ApiControllers
{
   //[Authorize]
   [AllowAnonymous]
   [RoutePrefix("api/Observation")]
   public class ObservationController : ApiController
   {
      private readonly IObservationRepository _observationRepository;
      private string loggedUserId;

      public ObservationController()
      {
         loggedUserId = User.Identity.GetUserId();
      }

      public ObservationController(IObservationRepository observationRepository) : this()
      {
         _observationRepository = observationRepository;
      }

      [Route("GetObservation/{id?}")]
      [HttpGet]
      public HttpResponseMessage GetObservation(int id)
      {
         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         var observation = _observationRepository.GetObservation(id).FirstOrDefault();

         if (observation == null)
            return Request.CreateResponse(HttpStatusCode.OK, "err Observation nie istenieje");

         var result = new ObservationVm(observation);
         return Request.CreateResponse(HttpStatusCode.OK, result);
      }

      //[Route("AddObservation")]
      [HttpPost, HttpOptions]
      public HttpResponseMessage AddObservation(ObservationVm observationVm)
      {
         if (Request.Method == HttpMethod.Options)
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         if (!ModelState.IsValid)
            return Request.CreateResponse(HttpStatusCode.BadRequest);

         var observation = NaproClientObservationService.ObservationVm2ObservationDb(observationVm);

         var result = _observationRepository.AddObservation(observation);
         return Request.CreateResponse(HttpStatusCode.OK,
            new string[] { result.ToString(), "success nowa Obserwacja dodana" });
      }

      [HttpPut, HttpOptions]
      public HttpResponseMessage UpdateObservation(ObservationVm observationVm)
      {
         if (Request.Method == HttpMethod.Options)
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         if (!ModelState.IsValid)
            return Request.CreateResponse(HttpStatusCode.BadRequest);

         var observationOwnerId = _observationRepository.GetObservationOwnerId(observationVm.Id).FirstOrDefault();

         if (observationOwnerId != loggedUserId)
            return Request.CreateResponse(HttpStatusCode.OK, "err nie twoja obserwacja");

         var observationQuery = _observationRepository.GetObservation(observationVm.Id);
         var observation = NaproClientObservationService.ObservationVm2ObservationDb(observationQuery.FirstOrDefault(), observationVm);

         var result = _observationRepository.UpdateObservation(observation);
         return Request.CreateResponse(HttpStatusCode.OK,
            new string[] { result.ToString(), "success dane obserwacji zmienione" });
      }

      [HttpDelete, HttpOptions]
      public HttpResponseMessage DeleteObservation(int id)
      {
         if (Request.Method == HttpMethod.Options)
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

         if (loggedUserId == null)
            //TODO: you are not logged message here
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "err niezalogowany");

         if (_observationRepository.GetObservationOwnerId(id).FirstOrDefault() != loggedUserId)
            return Request.CreateResponse(HttpStatusCode.OK, "err nie twoja obserwacja");

         var observation = _observationRepository.GetObservation(id).FirstOrDefault();

         var result = _observationRepository.DeleteObservation(id);
         return Request.CreateResponse(HttpStatusCode.OK, "success obsewacja usunieta");
      }
   }
}



