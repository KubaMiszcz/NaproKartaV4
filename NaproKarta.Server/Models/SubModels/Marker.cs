using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class Marker
	{
		[Key]
		public string Id { get; set; }
		[DataType(DataType.ImageUrl)]
		public string Url { get; set; } = "http://kubamiszcz.hekko24.pl/Naprokarta/markerNone.jpg";
	}
	internal sealed class MarkerMappings : EntityTypeConfiguration<Marker>
	{
		public MarkerMappings()
		{
			Property(p => p.Id).HasMaxLength(32).IsRequired();
			Property(p => p.Url).HasMaxLength(128).IsRequired();
		}
	}
}


