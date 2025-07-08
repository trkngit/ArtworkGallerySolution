using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class OwnerTransactionService : IOwnerTransactionService
    {
        private readonly IOwnerTransactionRepository _repository;
        private readonly IMapper _mapper;

        public OwnerTransactionService(IOwnerTransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<OwnerTransactionDto> GetAllOwnerTransactions()
        {
            var items = _repository.GetAll();
            return _mapper.Map<List<OwnerTransactionDto>>(items);
        }

        public OwnerTransactionDto? GetOwnerTransactionById(int id)
        {
            var item = _repository.GetById(id);
            return _mapper.Map<OwnerTransactionDto>(item);
        }

        public void AddOwnerTransaction(OwnerTransactionDto dto)
        {
            var item = _mapper.Map<OwnerTransaction>(dto);
            _repository.Add(item);
        }

        public void UpdateOwnerTransaction(OwnerTransactionDto dto)
        {
            var item = _mapper.Map<OwnerTransaction>(dto);
            _repository.Update(item);
        }

        public void DeleteOwnerTransaction(int id)
        {
            _repository.Delete(id);
        }
    }
}