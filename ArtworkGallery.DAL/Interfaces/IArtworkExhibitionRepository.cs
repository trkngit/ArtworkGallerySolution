using ArtworkGallery.DAL.Models.RelationshipEntities;

namespace ArtworkGallery.DAL.Interfaces
{
    public interface IArtworkExhibitionRepository
    {
        List<ArtworkExhibition> GetAll();

        ArtworkExhibition? GetById(int id);

        void Add (ArtworkExhibition artworkExhibition);

        void Update(ArtworkExhibition artworkExhibition);

        void Delete(int id);
    }
}