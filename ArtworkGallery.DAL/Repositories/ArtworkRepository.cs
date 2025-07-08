using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories
{
    public class ArtworkRepository : IArtworkRepository
    {
        private readonly ApplicationDbContext _context;

        public ArtworkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Artwork> GetAll()
        {
            return _context.Artworks.ToList();
        }

        public Artwork? GetById(int id)
        {
            return _context.Artworks.FirstOrDefault(a => a.ArtworkId == id);
        }

        public void Add(Artwork artwork)
        {
            _context.Artworks.Add(artwork);
            _context.SaveChanges();
        }

        public void Update(Artwork artwork)
        {
            var existingArtwork = _context.Artworks.Find(artwork.ArtworkId);
            if (existingArtwork != null)
            {
                existingArtwork.Artworktitle = artwork.Artworktitle;
                existingArtwork.ArtworkYearCreated = artwork.ArtworkYearCreated;
                existingArtwork.Artworkmedium = artwork.Artworkmedium;
                existingArtwork.ArtistId = artwork.ArtistId;
                existingArtwork.OwnerId = artwork.OwnerId;
                existingArtwork.GalleryId = artwork.GalleryId;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var artwork = _context.Artworks.Find(id);
            if (artwork != null)
            {
                _context.Artworks.Remove(artwork);
                _context.SaveChanges();
            }
        }
    }
}