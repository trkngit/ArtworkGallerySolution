using System;
namespace ArtworkGallery.DAL.Models
{
	public class Restoration
	{
		public int RestorationId { get; set; }
		public DateTime RestorationDate { get; set; }
		public string? RestorerName { get; set; }
		public string? RestorationNotes { get; set; }
		public int ArtworkId { get; set; }
		public Restoration()
		{
		}
	}
}

