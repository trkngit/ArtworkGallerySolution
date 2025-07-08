namespace ArtworkGallery.DAL.Models
{
    public class Artwork
    {
        public int ArtworkId { get; set; }
        public string? Artworktitle { get; set; }
        public int ArtworkYearCreated { get; set; }
        public string? Artworkmedium { get; set; }
        public int ArtistId { get; set; }
        public int GalleryId { get; set; }
        public int OwnerId { get; set; }
    }
}