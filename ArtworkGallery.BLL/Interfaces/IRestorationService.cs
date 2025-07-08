using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IRestorationService
    {
        List<RestorationDto> GetAllRestorations();
        RestorationDto? GetRestorationById(int id);
        void AddRestoration(RestorationDto restorationDto);
        void UpdateRestoration(RestorationDto restorationDto);
        void DeleteRestoration(int id);
    }
}