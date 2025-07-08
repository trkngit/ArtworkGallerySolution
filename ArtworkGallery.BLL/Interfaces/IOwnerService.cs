using ArtworkGallery.BLL.DTOs;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Interfaces
{
    public interface IOwnerService
    {
        List<OwnerDto> GetAllOwners();
        OwnerDto? GetOwnerById(int id);
        void AddOwner(OwnerDto ownerDto);
        void UpdateOwner(OwnerDto ownerDto);
        void DeleteOwner(int id);
    }
}