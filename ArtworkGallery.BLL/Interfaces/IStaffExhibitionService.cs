using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IStaffExhibitionService
    {
        List<StaffExhibitionDto> GetAllStaffExhibitions();
        StaffExhibitionDto? GetStaffExhibitionById(int id);
        void AddStaffExhibition(StaffExhibitionDto dto);
        void UpdateStaffExhibition(StaffExhibitionDto dto);
        void DeleteStaffExhibition(int id);
    }
}