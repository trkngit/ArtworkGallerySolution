using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IOwnerTransactionService
    {
        List<OwnerTransactionDto> GetAllOwnerTransactions();
        OwnerTransactionDto? GetOwnerTransactionById(int id);
        void AddOwnerTransaction(OwnerTransactionDto dto);
        void UpdateOwnerTransaction(OwnerTransactionDto dto);
        void DeleteOwnerTransaction(int id);
    }
}