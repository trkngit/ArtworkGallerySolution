using ArtworkGallery.DAL.Models;

namespace ArtworkGallery.DAL.Interfaces
{
    public interface IExhibitionRepository
    {
        List<Exhibition> GetAll();

        Exhibition? GetById(int id);

        void Delete (int id);

        void Add(Exhibition exhibition);

        void Update(Exhibition exhibition);
    }
}