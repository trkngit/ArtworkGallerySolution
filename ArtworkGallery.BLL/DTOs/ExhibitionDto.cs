namespace ArtworkGallery.BLL.DTOs{
    public class ExhibitionDto{
        public int ExhibitionId { get; set; }
		public string? ExhibitionName { get; set; }
		public string? ExhibitionLocation { get; set; }
		public DateTime ExhibitionStartDate { get; set; }
		public DateTime ExhibitonEndDate { get; set; }
		public int GalleryId { get; set; }

	}
}