using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class SpecializationService : ISpecializationService
    {
        private readonly ISpecializationRepository _specializationRepository;
        private readonly IMapper _mapper;

        public SpecializationService(ISpecializationRepository specializationRepository, IMapper mapper)
        {
            _specializationRepository = specializationRepository;
            _mapper = mapper;
        }

        public List<SpecializationDto> GetAllSpecializations() =>
            _mapper.Map<List<SpecializationDto>>(_specializationRepository.GetAll());

        public SpecializationDto? GetSpecializationById(int id) =>
            _mapper.Map<SpecializationDto>(_specializationRepository.GetById(id));

        public void AddSpecialization(SpecializationDto specializationDto) =>
            _specializationRepository.Add(_mapper.Map<Specialization>(specializationDto));

        public void UpdateSpecialization(SpecializationDto specializationDto) =>
            _specializationRepository.Update(_mapper.Map<Specialization>(specializationDto));

        public void DeleteSpecialization(int id) =>
            _specializationRepository.Delete(id);
    }
}