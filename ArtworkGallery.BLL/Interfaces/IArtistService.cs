using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IArtistService
    {
        List<ArtistDto> GetAllArtists();
        ArtistDto? GetArtistById(int id);
        void AddArtist(ArtistDto artistDto);
        void UpdateArtist(ArtistDto artistDto);
        void DeleteArtist(int id);
    }
}