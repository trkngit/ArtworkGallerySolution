using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Models.RelationshipEntities;

namespace ArtworkGallery.DAL.Interfaces
{
    public interface ISpecializationArtistRepository
    {
        List<SpecializationArtist> GetAll();

        SpecializationArtist? GetById(int id);

        void Add(SpecializationArtist artist);

        void Update(SpecializationArtist artist);

        void Delete(int id);
    }
}