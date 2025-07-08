using System;
namespace ArtworkGallery.DAL.Models.RelationshipEntities
{
	public class SpecializationArtist
	{
        public int SpecializationId { get; set; }
		public int ArtistId { get; set; }

        public SpecializationArtist()
		{
		}
	}
}

