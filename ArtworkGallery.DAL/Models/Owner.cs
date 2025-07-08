using System;
namespace ArtworkGallery.DAL.Models
{
	public class Owner
	{
		public int OwnerId { get; set; }
		public string? OwnerName { get; set; }
		public string? OwnerContactInfo { get; set; }
		public string? OwnerType { get; set; }
		public Owner()
		{
		}
	}
}

