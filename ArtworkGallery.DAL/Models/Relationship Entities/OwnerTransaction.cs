using System;
namespace ArtworkGallery.DAL.Models.RelationshipEntities
{
	public class OwnerTransaction
	{
		public int TransactionId { get; set; }
		public int OwnerId { get; set; }
		public string? Role { get; set; }

		public OwnerTransaction()
		{
		}
	}
}

