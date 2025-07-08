using ArtworkGallery.DAL.Models;
namespace ArtworkGallery.DAL.Interfaces;
public interface IArtworkRepository
{
    List<Artwork> GetAll();
    Artwork? GetById(int id);
    void Add(Artwork artwork);
    void Update(Artwork artwork);
    void Delete(int id);
}