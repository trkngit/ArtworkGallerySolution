using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;

        public ArtistService(IArtistRepository artistRepository, IMapper mapper)
        {
            _artistRepository = artistRepository;
            _mapper = mapper;
        }

        public List<ArtistDto> GetAllArtists()
        {
            var artists = _artistRepository.GetAll();
            return _mapper.Map<List<ArtistDto>>(artists);
        }

        public ArtistDto? GetArtistById(int id)
        {
            var artist = _artistRepository.GetById(id);
            return _mapper.Map<ArtistDto>(artist);
        }

        public void AddArtist(ArtistDto artistDto)
        {
            var artist = _mapper.Map<Artist>(artistDto);
            _artistRepository.Add(artist);
        }

        public void UpdateArtist(ArtistDto artistDto)
        {
            var artist = _mapper.Map<Artist>(artistDto);
            _artistRepository.Update(artist);
        }

        public void DeleteArtist(int id)
        {
            _artistRepository.Delete(id);
        }
    }
}