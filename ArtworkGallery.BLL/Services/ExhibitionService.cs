using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class ExhibitionService : IExhibitionService
    {
        private readonly IExhibitionRepository _exhibitionRepository;
        private readonly IMapper _mapper;

        public ExhibitionService(IExhibitionRepository exhibitionRepository, IMapper mapper)
        {
            _exhibitionRepository = exhibitionRepository;
            _mapper = mapper;
        }

        public List<ExhibitionDto> GetAllExhibitions() =>
            _mapper.Map<List<ExhibitionDto>>(_exhibitionRepository.GetAll());

        public ExhibitionDto? GetExhibitionById(int id) =>
            _mapper.Map<ExhibitionDto>(_exhibitionRepository.GetById(id));

        public void AddExhibition(ExhibitionDto exhibitionDto) =>
            _exhibitionRepository.Add(_mapper.Map<Exhibition>(exhibitionDto));

        public void UpdateExhibition(ExhibitionDto exhibitionDto) =>
            _exhibitionRepository.Update(_mapper.Map<Exhibition>(exhibitionDto));

        public void DeleteExhibition(int id) =>
            _exhibitionRepository.Delete(id);
    }
}