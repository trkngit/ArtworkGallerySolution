namespace ArtworkGallery.BLL.DTOs
{
    public class ArtistDto
    {
        public int ArtistId { get; set; }
		public string? ArtistName { get; set; }
		public int ArtistBirthYear { get; set; }
		public string? ArtistCountry { get; set; }
		public string? ArtistBio { get; set; }
    }
}