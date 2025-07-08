using System;
namespace ArtworkGallery.DAL.Models.RelationshipEntities
{
	public class StaffExhibition
	{
		public int StaffId { get; set; }
		public int ExhibitionId { get; set; }
		public StaffExhibition()
		{
		}
	}
}

