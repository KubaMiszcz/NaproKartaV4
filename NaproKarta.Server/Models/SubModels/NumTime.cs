using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace NaproKarta.Server.Models
{
	public class NumTime
	{
		[Key]
		public string Id { get; set; }
	}
	internal sealed class NumTimeMappings : EntityTypeConfiguration<NumTime>
	{
		public NumTimeMappings()
		{
			Property(p => p.Id).HasMaxLength(2).IsRequired();
		}
	}
}