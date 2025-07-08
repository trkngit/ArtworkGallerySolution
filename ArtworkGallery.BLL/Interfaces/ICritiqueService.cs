using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface ICritiqueService
    {
        List<CritiqueDto> GetAllCritiques();
        CritiqueDto? GetCritiqueById(int id);
        void AddCritique(CritiqueDto critiqueDto);
        void UpdateCritique(CritiqueDto critiqueDto);
        void DeleteCritique(int id);
    }
}