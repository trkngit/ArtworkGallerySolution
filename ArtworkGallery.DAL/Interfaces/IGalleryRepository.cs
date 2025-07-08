using ArtworkGallery.DAL.Models;

namespace ArtworkGallery.DAL.Interfaces
{
    public interface IGalleryRepository{
        List<Gallery> GetAll();

        Gallery? GetById(int id);

        void Add(Gallery gallery);

        void Update(Gallery gallery);

        void Delete(int id);

    }
}