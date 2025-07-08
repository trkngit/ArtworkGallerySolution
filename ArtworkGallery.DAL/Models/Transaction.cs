using System;
namespace ArtworkGallery.DAL.Models
{
	public class Transaction
	{
		public int TransactionId { get; set; }
		public decimal TransactionSalePrice { get; set; }
		public DateTime TransactionSaleDate { get; set; }
		public int ArtworkId { get; set; }

		public Transaction()
		{
		}
	}
}

