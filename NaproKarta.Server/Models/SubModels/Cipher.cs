using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class Cipher
	{
		[Key]
		public int Id { get; set; }
		public string Value { get; set; }
	}
	internal sealed class CipherMappings : EntityTypeConfiguration<Cipher>
	{
		public CipherMappings()
		{
			Property(p => p.Value).HasMaxLength(4).IsRequired();
		}
	}
}


