namespace ArtworkGallery.BLL.DTOs
{
    public class OwnerTransactionDto
    {
        public int OwnerTransactionId { get; set; }
        public int TransactionId { get; set; }
        public int OwnerId { get; set; }
        public string? Role { get; set; }
    }
}