using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
   public class Picture
   {
      [Key]
      public int Id { get; set; }
      [Url]
      public string Url { get; set; }

      public int ObservationId { get; set; }
      public virtual Observation Observation { get; set; }
   }
   internal sealed class PictureMappings : EntityTypeConfiguration<Picture>
   {
      public PictureMappings()
      {
         Property(p => p.Id).IsRequired();
      }
   }
}


