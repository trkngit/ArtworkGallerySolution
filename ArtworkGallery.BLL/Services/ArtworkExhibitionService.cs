using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class ArtworkExhibitionService : IArtworkExhibitionService
    {
        private readonly IArtworkExhibitionRepository _repository;
        private readonly IMapper _mapper;

        public ArtworkExhibitionService(IArtworkExhibitionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<ArtworkExhibitionDto> GetAllArtworkExhibitions()
        {
            var items = _repository.GetAll();
            return _mapper.Map<List<ArtworkExhibitionDto>>(items);
        }

        public ArtworkExhibitionDto? GetArtworkExhibitionById(int id)
        {
            var item = _repository.GetById(id);
            return _mapper.Map<ArtworkExhibitionDto>(item);
        }

        public void AddArtworkExhibition(ArtworkExhibitionDto dto)
        {
            var item = _mapper.Map<ArtworkExhibition>(dto);
            _repository.Add(item);
        }

        public void UpdateArtworkExhibition(ArtworkExhibitionDto dto)
        {
            var item = _mapper.Map<ArtworkExhibition>(dto);
            _repository.Update(item);
        }

        public void DeleteArtworkExhibition(int id)
        {
            _repository.Delete(id);
        }
    }
}