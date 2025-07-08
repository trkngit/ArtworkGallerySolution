using System;
namespace ArtworkGallery.DAL.Models
{
	public class Specialization
	{
		public int SpecializationId { get; set; }
		public string? SpecializationGenre { get; set; }
		public string? SpecializationMediumType { get; set; }

		public Specialization()
		{
		}
	}
}

