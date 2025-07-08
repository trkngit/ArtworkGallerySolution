using System;

namespace ArtworkGallery.BLL.DTOs
{
    public class RestorationDto
    {
        public int RestorationId { get; set; }
        public DateTime RestorationDate { get; set; }
        public string? RestorerName { get; set; }
        public string? RestorationNotes { get; set; }
        public int ArtworkId { get; set; }
    }
}