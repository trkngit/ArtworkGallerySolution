using System;
namespace ArtworkGallery.DAL.Models
{
	public class Artist
	{ 

		public int ArtistId { get; set; }
		public string? ArtistName { get; set; }
		public int ArtistBirthYear { get; set; }
		public string? ArtistCountry { get; set; }
		public string? ArtistBio { get; set; }
	
		public Artist()
		{
		}
	}
}

