using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories{
    public class TransactionRepository : ITransactionRepository{
        private readonly ApplicationDbContext _context;

        public TransactionRepository(ApplicationDbContext context){
            _context = context;
        }
        public List<Transaction> GetAll(){
            return _context.Transactions.ToList();
        }
        public Transaction? GetById(int id){
            return _context.Transactions.FirstOrDefault(t => t.TransactionId == id);
        }
        public void Add(Transaction transaction){
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
        public void Update(Transaction transaction){
            var existingTransaction = _context.Transactions.Find(transaction.TransactionId);
            if (existingTransaction != null)
            {
                existingTransaction.TransactionId = transaction.TransactionId;
                existingTransaction.TransactionSaleDate = transaction.TransactionSaleDate;
                existingTransaction.TransactionSalePrice = transaction.TransactionSalePrice;

                _context.SaveChanges();
            }
        }
        public void Delete(int id){
            var transaction = _context.Transactions.Find(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
        }
    }
}