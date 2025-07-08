using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class SpecializationArtistService : ISpecializationArtistService
    {
        private readonly ISpecializationArtistRepository _repository;
        private readonly IMapper _mapper;

        public SpecializationArtistService(ISpecializationArtistRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<SpecializationArtistDto> GetAllSpecializationArtists()
        {
            var items = _repository.GetAll();
            return _mapper.Map<List<SpecializationArtistDto>>(items);
        }

        public SpecializationArtistDto? GetSpecializationArtistById(int id)
        {
            var item = _repository.GetById(id);
            return _mapper.Map<SpecializationArtistDto>(item);
        }

        public void AddSpecializationArtist(SpecializationArtistDto dto)
        {
            var item = _mapper.Map<SpecializationArtist>(dto);
            _repository.Add(item);
        }

        public void UpdateSpecializationArtist(SpecializationArtistDto dto)
        {
            var item = _mapper.Map<SpecializationArtist>(dto);
            _repository.Update(item);
        }

        public void DeleteSpecializationArtist(int id)
        {
            _repository.Delete(id);
        }
    }
}