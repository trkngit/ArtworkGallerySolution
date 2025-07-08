using ArtworkGallery.DAL.Models;

namespace ArtworkGallery.DAL.Interfaces{
    public interface IRestorationRepository{
        List<Restoration> GetAll();

        Restoration? GetById(int id);

        void Add (Restoration restoration);

        void Update(Restoration restoration);

        void Delete(int id);
    }
}