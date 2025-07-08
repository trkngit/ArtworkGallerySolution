using System.Collections.Generic;
using System.Linq;
using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models.RelationshipEntities;

namespace ArtworkGallery.DAL.Repositories
{
    public class OwnerTransactionRepository : IOwnerTransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public OwnerTransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<OwnerTransaction> GetAll()
        {
            return _context.OwnerTransactions.ToList();
        }

        public OwnerTransaction? GetById(int id)
        {
            return _context.OwnerTransactions.FirstOrDefault(ot => ot.TransactionId == id);
        }

        public void Add(OwnerTransaction ownerTransaction)
        {
            _context.OwnerTransactions.Add(ownerTransaction);
            _context.SaveChanges();
        }

        public void Update(OwnerTransaction ownerTransaction)
        {
            var existing = _context.OwnerTransactions.Find(ownerTransaction.TransactionId);
            if (existing != null)
            {
                existing.OwnerId = ownerTransaction.OwnerId;
                existing.Role = ownerTransaction.Role;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var ownerTransaction = _context.OwnerTransactions.Find(id);
            if (ownerTransaction != null)
            {
                _context.OwnerTransactions.Remove(ownerTransaction);
                _context.SaveChanges();
            }
        }
    }
}