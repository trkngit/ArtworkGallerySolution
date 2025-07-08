using System;
namespace ArtworkGallery.DAL.Models
{
	public class Gallery
	{
		public int GalleryId { get; set; }
		public string? GalleryName { get; set; }
		public string? GalleryAddress { get; set; }
		public string? GalleryPhone { get; set; }
		public string? GalleryManager { get; set; }

		public Gallery()
		{
		}
	}
}

