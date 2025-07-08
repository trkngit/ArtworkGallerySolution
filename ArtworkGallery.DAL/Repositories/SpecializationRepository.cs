using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories{
    public class SpecializationRepository : ISpecializationRepository{
        private readonly ApplicationDbContext _context;

        public SpecializationRepository(ApplicationDbContext context){
            _context = context;
        }

        public List<Specialization> GetAll()
        {
            return _context.Specializations.ToList();
        }

        public  Specialization? GetById(int id){
            return _context.Specializations.FirstOrDefault(s => s.SpecializationId == id);
        }

        public void Add(Specialization specialization){
            _context.Specializations.Add(specialization);
            _context.SaveChanges();
        }

        public void Update(Specialization specialization){
            var existingSpecialization = _context.Specializations.Find(specialization.SpecializationId);
            if (existingSpecialization != null)
            {
                existingSpecialization.SpecializationGenre = specialization.SpecializationGenre;
                existingSpecialization.SpecializationId = specialization.SpecializationId;
                existingSpecialization.SpecializationMediumType = specialization.SpecializationMediumType;
                _context.SaveChanges();
            }
        }
        public void Delete(int id){
            var specialization = _context.Specializations.Find(id);
            if (specialization != null)
            {
                _context.Specializations.Remove(specialization);
                _context.SaveChanges();
            }
        }
    }
}