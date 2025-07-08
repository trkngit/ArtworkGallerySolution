using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface ISpecializationService
    {
        List<SpecializationDto> GetAllSpecializations();
        SpecializationDto? GetSpecializationById(int id);
        void AddSpecialization(SpecializationDto specializationDto);
        void UpdateSpecialization(SpecializationDto specializationDto);
        void DeleteSpecialization(int id);
    }
}