using ArtworkGallery.DAL.Models;
namespace ArtworkGallery.DAL.Interfaces;

public interface ISpecializationRepository
{
    List<Specialization> GetAll();

    Specialization? GetById(int id);

    void Add(Specialization specialization);

    void Delete(int id);

    void Update(Specialization specialization);
}