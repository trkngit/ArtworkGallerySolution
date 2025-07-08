using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IExhibitionService
    {
        List<ExhibitionDto> GetAllExhibitions();
        ExhibitionDto? GetExhibitionById(int id);
        void AddExhibition(ExhibitionDto exhibitionDto);
        void UpdateExhibition(ExhibitionDto exhibitionDto);
        void DeleteExhibition(int id);
    }
}