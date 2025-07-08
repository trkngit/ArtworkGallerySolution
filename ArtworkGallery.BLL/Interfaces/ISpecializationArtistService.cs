using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface ISpecializationArtistService
    {
        List<SpecializationArtistDto> GetAllSpecializationArtists();
        SpecializationArtistDto? GetSpecializationArtistById(int id);
        void AddSpecializationArtist(SpecializationArtistDto dto);
        void UpdateSpecializationArtist(SpecializationArtistDto dto);
        void DeleteSpecializationArtist(int id);
    }
}