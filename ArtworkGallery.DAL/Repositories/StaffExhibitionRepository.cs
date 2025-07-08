using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories{
    public class StaffExhibitionRepository : IStaffExhibitionRepository{
        private readonly ApplicationDbContext _context;

        public StaffExhibitionRepository(ApplicationDbContext context){
            _context = context;
        }

        public List<StaffExhibition>GetAll(){
            return _context.StaffExhibitions.ToList();
        }

        public StaffExhibition? GetById(int id){
            return _context.StaffExhibitions.FirstOrDefault(se => se.ExhibitionId == id);
        }
        public void Add(StaffExhibition staffExhibition){
            _context.StaffExhibitions.Add(staffExhibition);
            _context.SaveChanges();
        }

        public void Update(StaffExhibition staffExhibition){
            var existingStaffExhibition = _context.StaffExhibitions.Find(staffExhibition.StaffId);
            if(existingStaffExhibition != null){
                existingStaffExhibition.ExhibitionId = staffExhibition.ExhibitionId;
                existingStaffExhibition.StaffId = staffExhibition.StaffId;

                _context.SaveChanges();
            }
        }
        public void Delete(int id){
            var staffExhibition = _context.StaffExhibitions.Find(id);
            if(staffExhibition != null){
                _context.StaffExhibitions.Remove(staffExhibition);
                _context.SaveChanges();
            }
        }
    }
}