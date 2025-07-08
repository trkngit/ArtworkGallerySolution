using System;
namespace ArtworkGallery.DAL.Models
{
	public class Exhibition
	{
		public int ExhibitionId { get; set; }
		public string? ExhibitionName { get; set; }
		public string? ExhibitionLocation { get; set; }
		public DateTime ExhibitionStartDate { get; set; }
		public DateTime ExhibitonEndDate { get; set; }
		public int GalleryId { get; set; }

		public Exhibition()
		{
		}
	}
}

