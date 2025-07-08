using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface ITransactionService
    {
        List<TransactionDto> GetAllTransactions();
        TransactionDto? GetTransactionById(int id);
        void AddTransaction(TransactionDto transactionDto);
        void UpdateTransaction(TransactionDto transactionDto);
        void DeleteTransaction(int id);
    }
}