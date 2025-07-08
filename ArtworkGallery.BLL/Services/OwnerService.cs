using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;
        private readonly IMapper _mapper;

        public OwnerService(IOwnerRepository ownerRepository, IMapper mapper)
        {
            _ownerRepository = ownerRepository;
            _mapper = mapper;
        }

        public List<OwnerDto> GetAllOwners() =>
            _mapper.Map<List<OwnerDto>>(_ownerRepository.GetAll());

        public OwnerDto? GetOwnerById(int id) =>
            _mapper.Map<OwnerDto>(_ownerRepository.GetById(id));

        public void AddOwner(OwnerDto ownerDto) =>
            _ownerRepository.Add(_mapper.Map<Owner>(ownerDto));

        public void UpdateOwner(OwnerDto ownerDto) =>
            _ownerRepository.Update(_mapper.Map<Owner>(ownerDto));

        public void DeleteOwner(int id) =>
            _ownerRepository.Delete(id);
    }
}