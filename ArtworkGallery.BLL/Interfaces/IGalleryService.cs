using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IGalleryService
    {
        List<GalleryDto> GetAllGalleries();
        GalleryDto? GetGalleryById(int id);
        void AddGallery(GalleryDto galleryDto);
        void UpdateGallery(GalleryDto galleryDto);
        void DeleteGallery(int id);
    }
}