using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IStaffService
    {
        List<StaffDto> GetAllStaff();
        StaffDto? GetStaffById(int id);
        void AddStaff(StaffDto staffDto);
        void UpdateStaff(StaffDto staffDto);
        void DeleteStaff(int id);
    }
}