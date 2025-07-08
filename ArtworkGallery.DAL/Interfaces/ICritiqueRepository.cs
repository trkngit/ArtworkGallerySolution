using ArtworkGallery.DAL.Models;
namespace ArtworkGallery.DAL.Interfaces;

public interface ICritiqueRepository{
    List<Critique> GetAll();

    Critique? GetById(int id);

    void Add(Critique critique);
    void Update(Critique critique);
    void Delete(int id);

}