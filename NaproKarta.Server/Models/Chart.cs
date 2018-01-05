using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;
using Newtonsoft.Json;

namespace NaproKarta.Server.Models
{
	public class Chart
	{
		[Key]
		public int Id { get; set; }
		//public int UserDataId { get; set; }
		//public virtual UserData UserData { get; set; }      
		public string UserId { get; set; }
		public virtual ApplicationUser User { get; set; }
		public string Title { get; set; }
		public string Note { get; set; }
		public virtual IList<Cycle> Cycles { get; set; }
	}
	/*
	internal sealed class ResumeMappings : IEntityTypeConfiguration<Resume>
	{
		public void Configure(EntityTypeBuilder<Resume> builder)
		{
			builder.ToTable("Resumes", "Application");

			builder.Property(p => p.FirstName).IsRequired().HasMaxLength(128);
			builder.Property(p => p.LastName).IsRequired().HasMaxLength(128);
			builder.Property(p => p.Email).IsRequired().HasMaxLength(128);
			builder.HasIndex(p => p.Email).IsUnique();
			builder.Property(p => p.FullText).IsRequired();
			builder.ToTable("ResumesKeyWords", "Application");
			builder.HasKey(p => new
			{
				p.ResumeId,
				p.KeyWordId
			});

			builder.Ignore(p => p.FullName);
						builder.ToTable("KeyWords", "Application");
			builder.Property(p => p.Name).IsRequired().HasMaxLength(128);
			builder.HasIndex(p => p.Name).IsUnique();
		}
	}
	*/
}