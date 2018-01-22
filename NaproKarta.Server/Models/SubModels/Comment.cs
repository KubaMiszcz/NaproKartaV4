using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

//TODO: change to all cobinations of comments 3x bool => 8combinations B,W,I
namespace NaproKarta.Server.Models
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }
		public string Content { get; set; }

      public virtual IList<Observation> Observations { get; set; }
   }
	//internal sealed class CommentMappings : EntityTypeConfiguration<Comment>
	//{
	//	public CommentMappings()
	//	{
	//		HasKey(p => p.Id);
	//		Property(p => p.Content).HasMaxLength(16).IsRequired();
	//	}
	//}
}


