using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using NaproKarta.Server.Interfaces;
using NaproKarta.Server.Models;

namespace NaproKarta.Server.Models
{
	public class Observation
	{
		[Key]
		public int Id { get; set; }

		public int CycleId { get; set; }
		public virtual Cycle Cycle { get; set; }

		public int NumberInCycle { get; set; }

		public string MarkerId { get; set; }
		public virtual Marker Marker { get; set; }

		public DateTime Date { get; set; }

		public int LetterId { get; set; }
		public virtual Letter Letter { get; set; }

		public bool IsB { get; set; }

		public int NumTimeId { get; set; }
		public virtual NumTime NumTime { get; set; }

		public int CipherId { get; set; }
		public virtual Cipher Cipher { get; set; }

		public int CipherCdId { get; set; }
		public virtual CipherCd CipherCd { get; set; }

		public int CommentId { get; set; }
		public virtual Comment Comment { get; set; }

		public virtual IList<ObservationNote> Notes { get; set; }
	}
}