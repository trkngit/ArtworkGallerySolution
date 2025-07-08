using ArtworkGallery.DAL.Models;
namespace ArtworkGallery.DAL.Interfaces;

public interface IArtistRepository
{

    List<Artist> GetAll();

    Artist? GetById(int id);

    void Add(Artist artist);

    void Update(Artist artist);

    void Delete(int id);
}