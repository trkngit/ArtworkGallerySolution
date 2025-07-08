using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public List<TransactionDto> GetAllTransactions()
        {
            var transactions = _transactionRepository.GetAll();
            return _mapper.Map<List<TransactionDto>>(transactions);
        }

        public TransactionDto? GetTransactionById(int id)
        {
            var transaction = _transactionRepository.GetById(id);
            return _mapper.Map<TransactionDto>(transaction);
        }

        public void AddTransaction(TransactionDto transactionDto)
        {
            var transaction = _mapper.Map<Transaction>(transactionDto);
            _transactionRepository.Add(transaction);
        }

        public void UpdateTransaction(TransactionDto transactionDto)
        {
            var transaction = _mapper.Map<Transaction>(transactionDto);
            _transactionRepository.Update(transaction);
        }

        public void DeleteTransaction(int id)
        {
            _transactionRepository.Delete(id);
        }
    }
}