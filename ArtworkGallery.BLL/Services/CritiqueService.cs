using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class CritiqueService : ICritiqueService
    {
        private readonly ICritiqueRepository _critiqueRepository;
        private readonly IMapper _mapper;

        public CritiqueService(ICritiqueRepository critiqueRepository, IMapper mapper)
        {
            _critiqueRepository = critiqueRepository;
            _mapper = mapper;
        }

        public List<CritiqueDto> GetAllCritiques() =>
            _mapper.Map<List<CritiqueDto>>(_critiqueRepository.GetAll());

        public CritiqueDto? GetCritiqueById(int id) =>
            _mapper.Map<CritiqueDto>(_critiqueRepository.GetById(id));

        public void AddCritique(CritiqueDto critiqueDto) =>
            _critiqueRepository.Add(_mapper.Map<Critique>(critiqueDto));

        public void UpdateCritique(CritiqueDto critiqueDto) =>
            _critiqueRepository.Update(_mapper.Map<Critique>(critiqueDto));

        public void DeleteCritique(int id) =>
            _critiqueRepository.Delete(id);
    }
}