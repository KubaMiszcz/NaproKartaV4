using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class Cipher
	{
		[Key]
		public string Id { get; set; }
	}
	internal sealed class CipherMappings : EntityTypeConfiguration<Cipher>
	{
		public CipherMappings()
		{
			Property(p => p.Id).HasMaxLength(4).IsRequired();
		}
	}
}


