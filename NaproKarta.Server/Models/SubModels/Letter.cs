using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class Letter
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(3)]
		public string Value { get; set; }
	}

	//internal sealed class LetterMappings : EntityTypeConfiguration<Letter>
	//{
	//	public LetterMappings()
	//	{
	//		HasKey(p => p.Id);
	//		Property(p => p.Value).HasMaxLength(3).IsRequired();
	//	}
	//}
}


