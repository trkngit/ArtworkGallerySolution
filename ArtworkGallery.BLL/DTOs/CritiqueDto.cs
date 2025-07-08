namespace ArtworkGallery.BLL.DTOs
{
    public class CritiqueDto{
        public int CritiqueId { get; set; }
		public string? CritiqueName { get; set; }
		public DateTime CritiqueDate { get; set; }
		public int CritiqueRating { get; set; }
		public string? CritiqueComment { get; set; }
		public int ArtworkId { get; set; }


    }
}