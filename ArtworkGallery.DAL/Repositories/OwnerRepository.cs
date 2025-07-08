using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ArtworkGallery.DAL.Repositories{
    public class OwnerRepository : IOwnerRepository{

        private readonly ApplicationDbContext _context;

        public OwnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Owner> GetAll()
        {
            return _context.Owners.ToList();
        }

        public Owner? GetById(int id)
        {
            return _context.Owners.FirstOrDefault(o => o.OwnerId == id);
        }

        public void Add(Owner owner)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
        }

        public void Update(Owner owner)
        {
            var existingOwner = _context.Owners.Find(owner.OwnerId);
            if (existingOwner != null){
                existingOwner.OwnerContactInfo = owner.OwnerContactInfo;
                existingOwner.OwnerId = owner.OwnerId;
                existingOwner.OwnerName = owner.OwnerName;
                existingOwner.OwnerType = owner.OwnerType;

                _context.SaveChanges();

            }
        
        }

        public void Delete(int id){
            var owner = _context.Owners.Find(id);
            if (owner != null)
            {
                _context.Owners.Remove(owner);
                _context.SaveChanges();

            }
        }


    }
}