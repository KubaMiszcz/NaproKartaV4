using NaproKarta.Server.Models;

namespace NaproKarta.Client.ViewModels
{
   public class PictureVm
   {
      public int Id { get; set; }
      public string Url { get; set; }
      public int ObservationId { get; set; }

      public PictureVm() { }

      public PictureVm(Picture picture)
      {
         Id = picture.Id;
         Url = picture.Url;
         ObservationId = picture.ObservationId;
      }
   }
}