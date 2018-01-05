using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class CipherCd
	{
		[Key]
		public int Id { get; set; }
		public string Value { get; set; }
	}
	internal sealed class CipherCdMappings : EntityTypeConfiguration<CipherCd>
	{
		public CipherCdMappings()
		{
			Property(p => p.Value).HasMaxLength(3).IsRequired();
		}
	}
}


