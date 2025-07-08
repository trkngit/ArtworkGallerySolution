using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Models.RelationshipEntities;

namespace ArtworkGallery.DAL.Interfaces{
    public interface IStaffExhibitionRepository{
        List<StaffExhibition> GetAll();

        StaffExhibition? GetById(int id);

        void Add(StaffExhibition staffExhibition);

        void Update(StaffExhibition staffExhibition);

        void Delete(int id);
    }
}