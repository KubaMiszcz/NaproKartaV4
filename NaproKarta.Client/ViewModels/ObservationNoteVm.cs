using NaproKarta.Server.Models;

namespace NaproKarta.Client.ViewModels
{
	public class ObservationNoteVm
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public bool IsImportant { get; set; }

		public int ObservationId { get; set; }

		public ObservationNoteVm() { }


		public ObservationNoteVm(ObservationNote note)
		{
			Id = note.Id;
			Content = note.Content;
			IsImportant = note.IsImportant;
			ObservationId = note.ObservationId;
		}
	}
}