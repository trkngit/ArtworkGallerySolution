using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Linq;
using System.Collections.Generic;

namespace ArtworkGallery.DAL.Repositories{
    public class ExhibitionRepository : IExhibitionRepository{
        private readonly ApplicationDbContext _context;

        public ExhibitionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Exhibition> GetAll()
        {
            return _context.Exhibitions.ToList();
        }

        public Exhibition? GetById(int id)
        {
            return _context.Exhibitions.FirstOrDefault(e => e.ExhibitionId == id);
        }

        public void Add(Exhibition exhibition)
        {
            _context.Exhibitions.Add(exhibition);
            _context.SaveChanges();
        }

        public void Update(Exhibition exhibition)
        {
            var existingExhibition = _context.Exhibitions.Find(exhibition.ExhibitionId);

            if (existingExhibition != null)
            {
                existingExhibition.ExhibitionLocation = exhibition.ExhibitionLocation;
                existingExhibition.ExhibitionName = exhibition.ExhibitionName;
                existingExhibition.ExhibitionStartDate = exhibition.ExhibitionStartDate;
                existingExhibition.ExhibitonEndDate = exhibition.ExhibitonEndDate;
                existingExhibition.ExhibitionId = exhibition.ExhibitionId;

            }
        }
        public void Delete(int id){
            var exhibition = _context.Exhibitions.Find(id);
            if (exhibition != null){
                _context.Exhibitions.Remove(exhibition);
                _context.SaveChanges();
            }
            
        }
    }
}