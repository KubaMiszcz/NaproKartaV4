using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class CipherCd
	{
		[Key]
		public string Id { get; set; }
	}
	internal sealed class CipherCdMappings : EntityTypeConfiguration<CipherCd>
	{
		public CipherCdMappings()
		{
			Property(p => p.Id).HasMaxLength(3).IsRequired();
		}
	}
}


