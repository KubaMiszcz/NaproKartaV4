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
		public int Id { get; set; }
		public string Value { get; set; }
	}
	internal sealed class NumTimeMappings : EntityTypeConfiguration<NumTime>
	{
		public NumTimeMappings()
		{
			Property(p => p.Value).HasMaxLength(2).IsRequired();
		}
	}
}