using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.UI.Handlers
{
    public class ServiceType
    {
        public IArtworkService? ArtworkService { get; set; }
        public IArtistService? ArtistService { get; set; }
        public ICritiqueService? CritiqueService { get; set; }
        public IExhibitionService? ExhibitionService { get; set; }
        public IGalleryService? GalleryService { get; set; }
        public IOwnerService? OwnerService { get; set; }
        public IRestorationService? RestorationService { get; set; }
        public ISpecializationService? SpecializationService { get; set; }
        public IStaffService? StaffService { get; set; }
        public ITransactionService? TransactionService { get; set; }
        public IArtworkExhibitionService? ArtworkExhibitionService { get; set; }
        public IOwnerTransactionService? OwnerTransactionService { get; set; }
        public ISpecializationArtistService? SpecializationArtistService { get; set; }
        public IStaffExhibitionService? StaffExhibitionService { get; set; }
    }
}