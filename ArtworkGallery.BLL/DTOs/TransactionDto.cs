using System;

namespace ArtworkGallery.BLL.DTOs
{
    public class TransactionDto
    {
        public int TransactionId { get; set; }
        public decimal TransactionSalePrice { get; set; }
        public DateTime TransactionSaleDate { get; set; }
        public int ArtworkId { get; set; }
    }
}