using System.Xml.Serialization;
using ArtworkGallery.DAL.Models;

namespace ArtworkGallery.DAL.Interfaces{
    public interface IStaffRepository{
        List<Staff> GetAll();
        
        Staff? GetById(int id);

        void Add(Staff staff);

        void Update(Staff staff);

        void Delete(int id);

    }
}