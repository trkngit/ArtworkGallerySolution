using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories;

public class ArtistRepository : IArtistRepository
{
    private readonly ApplicationDbContext _context;

    public ArtistRepository(ApplicationDbContext context){
        _context = context;
    }

    public List<Artist>GetAll(){
        return _context.Artists.ToList();
    }

    public Artist? GetById(int id){
    return _context.Artists.FirstOrDefault(a => a.ArtistId == id);
    }

    public void Add(Artist artist){
        _context.Artists.Add(artist);
        _context.SaveChanges();
    }

    public void Update(Artist artist)
    {
        var existingArtist = _context.Artists.Find(artist.ArtistId);
        if(existingArtist != null)
        {
            existingArtist.ArtistName = artist.ArtistName;
            existingArtist.ArtistBio = artist.ArtistBio;
            existingArtist.ArtistBirthYear = artist.ArtistBirthYear;
            existingArtist.ArtistCountry = existingArtist.ArtistCountry;
            existingArtist.ArtistId = existingArtist.ArtistId;

            _context.SaveChanges();
        }
    }

    public void Delete(int id){
        var artist = _context.Artists.Find(id);
        if(artist != null){
            _context.Artists.Remove(artist);
            _context.SaveChanges();
        }
}


}