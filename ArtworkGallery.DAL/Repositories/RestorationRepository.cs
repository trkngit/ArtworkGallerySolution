using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Linq;
using System.Collections.Generic;

namespace ArtworkGallery.DAL.Repositories{
    public class RestorationRepository : IRestorationRepository{
        ApplicationDbContext _context;
        public RestorationRepository (ApplicationDbContext context){
            _context = context;
        }

        public List<Restoration> GetAll(){
            return _context.Restorations.ToList();
        }

        public Restoration? GetById(int id){
            return _context.Restorations.FirstOrDefault(r => r.RestorationId == id);
        }

        public void Add(Restoration restoration){
            _context.Restorations.Add(restoration);
            _context.SaveChanges();
        }
        public void Update(Restoration restoration){
            var existingRestoration = _context.Restorations.Find(restoration.RestorationId);
            if (existingRestoration != null)
            {
                existingRestoration.RestorationDate = restoration.RestorationDate;
                existingRestoration.RestorationId = restoration.RestorationId;
                existingRestoration.RestorationNotes = restoration.RestorationNotes;
                existingRestoration.RestorerName = restoration.RestorerName;

                _context.SaveChanges();
            }
            
        }
        public void Delete(int id){
            var restoration = _context.Restorations.Find(id);
            if (restoration != null)
            {
                _context.Restorations.Remove(restoration);
                _context.SaveChanges();
            }
        }

    }
}