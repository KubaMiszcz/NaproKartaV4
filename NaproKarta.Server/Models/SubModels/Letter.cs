using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NaproKarta.Server.Models
{
	public class Letter
	{
		[Key,MaxLength(3)]
		public string Id { get; set; }
	}

	//internal sealed class LetterMappings : EntityTypeConfiguration<Letter>
	//{
	//	public LetterMappings()
	//	{
			
	//	}
	//}
}


