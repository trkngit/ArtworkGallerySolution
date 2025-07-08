using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IArtworkExhibitionService
    {
        List<ArtworkExhibitionDto> GetAllArtworkExhibitions();
        ArtworkExhibitionDto? GetArtworkExhibitionById(int id);
        void AddArtworkExhibition(ArtworkExhibitionDto dto);
        void UpdateArtworkExhibition(ArtworkExhibitionDto dto);
        void DeleteArtworkExhibition(int id);
    }
}