using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.BLL.Services
{
    public class ArtworkService : IArtworkService
    {
        private readonly IArtworkRepository _artworkRepository;
        private readonly IMapper _mapper;

        public ArtworkService(IArtworkRepository artworkRepository, IMapper mapper)
        {
            _artworkRepository = artworkRepository;
            _mapper = mapper;
        }

        public List<ArtworkDto> GetAllArtworks()
        {
            var artworks = _artworkRepository.GetAll();
            return _mapper.Map<List<ArtworkDto>>(artworks);
        }

        public ArtworkDto? GetArtworkById(int id)
        {
            var artwork = _artworkRepository.GetById(id);
            return _mapper.Map<ArtworkDto>(artwork);
        }

        public void AddArtwork(ArtworkDto artworkDto)
        {
            var artwork = _mapper.Map<Artwork>(artworkDto);
            _artworkRepository.Add(artwork);
        }

        public void UpdateArtwork(ArtworkDto artworkDto)
        {
            var artwork = _mapper.Map<Artwork>(artworkDto);
            _artworkRepository.Update(artwork);
        }

        public void DeleteArtwork(int id)
        {
            _artworkRepository.Delete(id);
        }
    }
}