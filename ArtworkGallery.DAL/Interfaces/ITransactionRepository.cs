using ArtworkGallery.DAL.Models;

namespace ArtworkGallery.DAL.Interfaces
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAll();

        Transaction? GetById(int id);

        void Add(Transaction transaction);

        void Update(Transaction transaction);

        void Delete(int id);

    }
}