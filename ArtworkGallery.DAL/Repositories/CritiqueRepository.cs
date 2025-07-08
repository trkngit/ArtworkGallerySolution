using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace ArtworkGallery.DAL.Repositories{
    public class CritiqueRepository : ICritiqueRepository
    {
        private readonly ApplicationDbContext _context;

        public CritiqueRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<Critique> GetAll(){
            return _context.Critiques.ToList();
        }

        public Critique? GetById(int id){
            return _context.Critiques.FirstOrDefault(c => c.CritiqueId == id);
        }

        public void Add(Critique critique){
            _context.Critiques.Add(critique);
            _context.SaveChanges();
        }
        public void Update(Critique critique){
            var existingCritique = _context.Critiques.Find(critique.CritiqueId);
            if (existingCritique != null)
            {
                existingCritique.CritiqueComment = critique.CritiqueComment;
                existingCritique.CritiqueDate = critique.CritiqueDate;
                existingCritique.CritiqueName = critique.CritiqueName;
                existingCritique.CritiqueRating = critique.CritiqueRating;
                existingCritique.CritiqueId = critique.CritiqueId;
            }

        }
        public void Delete(int id){
            var critique = _context.Critiques.Find(id);
            if(critique != null){
                _context.Critiques.Remove(critique);
                _context.SaveChanges();
            }
        }
    }
}