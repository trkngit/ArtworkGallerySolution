using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class StaffExhibitionService : IStaffExhibitionService
    {
        private readonly IStaffExhibitionRepository _repository;
        private readonly IMapper _mapper;

        public StaffExhibitionService(IStaffExhibitionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<StaffExhibitionDto> GetAllStaffExhibitions()
        {
            var items = _repository.GetAll();
            return _mapper.Map<List<StaffExhibitionDto>>(items);
        }

        public StaffExhibitionDto? GetStaffExhibitionById(int id)
        {
            var item = _repository.GetById(id);
            return _mapper.Map<StaffExhibitionDto>(item);
        }

        public void AddStaffExhibition(StaffExhibitionDto dto)
        {
            var item = _mapper.Map<StaffExhibition>(dto);
            _repository.Add(item);
        }

        public void UpdateStaffExhibition(StaffExhibitionDto dto)
        {
            var item = _mapper.Map<StaffExhibition>(dto);
            _repository.Update(item);
        }

        public void DeleteStaffExhibition(int id)
        {
            _repository.Delete(id);
        }
    }
}