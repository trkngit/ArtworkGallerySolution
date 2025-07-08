using ArtworkGallery.DAL.Models;
namespace ArtworkGallery.DAL.Interfaces;

public interface IOwnerRepository{
    List<Owner> GetAll();

    Owner? GetById(int id);

    void Add(Owner owner);

    void Update(Owner owner);

    void Delete(int id);
}