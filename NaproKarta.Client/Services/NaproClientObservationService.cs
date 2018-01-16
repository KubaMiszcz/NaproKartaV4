using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using NaproKarta.Client.ViewModels;
using NaproKarta.Server.Context;
using NaproKarta.Server.Models;

namespace NaproKarta.Client.Services
{
	public class NaproClientObservationService
   {
		internal static Observation ObservationVm2ObservationDb(ObservationVm observationVm)
		{
			var result = new Observation()
			{
				//Id = chartVm.Id,
				//Title = chartVm.Title,
				//Note = chartVm.Note,
			};
			return result;
		}
	}
}