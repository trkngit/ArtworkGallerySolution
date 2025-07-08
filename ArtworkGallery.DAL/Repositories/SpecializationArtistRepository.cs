using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories{
    public class SpecializationArtistRepository : ISpecializationArtistRepository{
        private readonly ApplicationDbContext _context;

        public SpecializationArtistRepository(ApplicationDbContext context){
            _context = context;
        }

        public List<SpecializationArtist> GetAll(){
            return _context.SpecializationArtists.ToList();
        }

        public SpecializationArtist? GetById(int id){
            return _context.SpecializationArtists.FirstOrDefault(sa => sa.SpecializationId == id);
        }

        public void Add(SpecializationArtist specializationArtist){
            _context.SpecializationArtists.Add(specializationArtist);
            _context.SaveChanges();
        }

        public void Update(SpecializationArtist specializationArtist){
            var existingSpecializationArtist = _context.SpecializationArtists.Find(specializationArtist.SpecializationId);
            if (existingSpecializationArtist != null)
            {
                existingSpecializationArtist.ArtistId = specializationArtist.ArtistId;
                existingSpecializationArtist.SpecializationId = specializationArtist.SpecializationId;

                _context.SaveChanges();
            }

        }
        public void Delete(int id){
            var specializationArtist = _context.SpecializationArtists.Find(id);
            if (specializationArtist != null){
                _context.SpecializationArtists.Remove(specializationArtist);
            }
            {
                
            }
        }
    }
}