using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class RestorationService : IRestorationService
    {
        private readonly IRestorationRepository _restorationRepository;
        private readonly IMapper _mapper;

        public RestorationService(IRestorationRepository restorationRepository, IMapper mapper)
        {
            _restorationRepository = restorationRepository;
            _mapper = mapper;
        }

        public List<RestorationDto> GetAllRestorations() =>
            _mapper.Map<List<RestorationDto>>(_restorationRepository.GetAll());

        public RestorationDto? GetRestorationById(int id) =>
            _mapper.Map<RestorationDto>(_restorationRepository.GetById(id));

        public void AddRestoration(RestorationDto restorationDto) =>
            _restorationRepository.Add(_mapper.Map<Restoration>(restorationDto));

        public void UpdateRestoration(RestorationDto restorationDto) =>
            _restorationRepository.Update(_mapper.Map<Restoration>(restorationDto));

        public void DeleteRestoration(int id) =>
            _restorationRepository.Delete(id);
    }
}