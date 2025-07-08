using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories{
    public class GalleryRepository : IGalleryRepository {
        private readonly ApplicationDbContext _context;

        public GalleryRepository(ApplicationDbContext context){
            _context = context;
        }

        public List<Gallery> GetAll(){
            return _context.Galleries.ToList();
        }

        public Gallery? GetById(int id){
            return _context.Galleries.FirstOrDefault(g => g.GalleryId == id);
        }

        public void Add(Gallery gallery){
            _context.Galleries.Add(gallery);
            _context.SaveChanges();
        }
        
        public void Update(Gallery gallery){
            var existingGallery = _context.Galleries.Find(gallery.GalleryId);
            if(existingGallery != null){
                existingGallery.GalleryAddress = gallery.GalleryAddress;
                existingGallery.GalleryId = gallery.GalleryId;
                existingGallery.GalleryManager = gallery.GalleryManager;
                existingGallery.GalleryName = gallery.GalleryName;
                existingGallery.GalleryPhone = gallery.GalleryPhone;
            }
        }
        public void Delete(int id){
            var gallery = _context.Galleries.Find(id);
            if (gallery != null)
            {
                _context.Galleries.Remove(gallery);
                _context.SaveChanges();        
            }
        }
    }
}