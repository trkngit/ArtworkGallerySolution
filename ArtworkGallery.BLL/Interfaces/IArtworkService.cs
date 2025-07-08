using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IArtworkService
    {
        List<ArtworkDto> GetAllArtworks();
        ArtworkDto? GetArtworkById(int id);
        void AddArtwork(ArtworkDto artworkDto);
        void UpdateArtwork(ArtworkDto artworkDto);
        void DeleteArtwork(int id);
    }
}