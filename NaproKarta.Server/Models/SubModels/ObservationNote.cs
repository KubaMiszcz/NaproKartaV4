using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class ObservationNote
	{
		[Key]
		public int Id { get; set; }
		public string Content { get; set; }
		public bool IsImportant { get; set; }

		public int ObservationId { get; set; }
		public virtual Observation Observation { get; set; }
	}
   internal sealed class ObservationNoteMappings : EntityTypeConfiguration<ObservationNote>
   {
      public ObservationNoteMappings()
      {
         Property(p => p.Id).IsRequired();
         Property(p => p.Content).HasMaxLength(1024).IsRequired();
         Property(p => p.IsImportant).IsRequired();
      }
   }
}


