using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories
{
    public class ArtworkExhibitionRepository : IArtworkExhibitionRepository
    {
        private readonly ApplicationDbContext _context;

        public ArtworkExhibitionRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public List<ArtworkExhibition> GetAll()
        {
            return _context.ArtworkExhibitions.ToList();
        }

        public ArtworkExhibition? GetById(int id)
        {
            return _context.ArtworkExhibitions.FirstOrDefault(ae => ae.ArtworkId == id);
        }

        public void Add(ArtworkExhibition artworkExhibition)
        {
            _context.ArtworkExhibitions.Add(artworkExhibition);
            _context.SaveChanges();
        }

        public void Update(ArtworkExhibition artworkExhibition)
        {
           
            var existingArtworkExhibition = _context.ArtworkExhibitions.Find(artworkExhibition.ArtworkId);
            
            if (existingArtworkExhibition != null){

                existingArtworkExhibition.ArtworkId = artworkExhibition.ArtworkId;
                existingArtworkExhibition.ExhibitionId = artworkExhibition.ExhibitionId;

                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            var artworkExhibition = _context.ArtworkExhibitions.Find(id);
            if (artworkExhibition != null)
            {
                _context.ArtworkExhibitions.Remove(artworkExhibition);

                _context.SaveChanges();
            }
            
        }

    }
}