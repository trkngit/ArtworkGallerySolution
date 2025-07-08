using System.Xml.Serialization;
using ArtworkGallery.DAL.Models.RelationshipEntities;

namespace ArtworkGallery.DAL.Interfaces{
    public interface IOwnerTransactionRepository
    {
        List<OwnerTransaction> GetAll();

        OwnerTransaction? GetById(int id);

        void Add(OwnerTransaction ownerTransaction);

        void Update(OwnerTransaction ownerTransaction);

        void Delete(int id);
    }

    
}