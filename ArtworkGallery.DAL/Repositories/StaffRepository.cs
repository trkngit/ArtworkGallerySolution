using ArtworkGallery.DAL.Data;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ArtworkGallery.DAL.Repositories{
    public class StaffRepository : IStaffRepository{
        private readonly ApplicationDbContext _context;

        public StaffRepository(ApplicationDbContext context){
            _context = context;
        }

        public List<Staff> GetAll(){
            return _context.Staffs.ToList();
        }

        public Staff? GetById(int id){
            return _context.Staffs.FirstOrDefault(s => s.StaffId == id);
        }

        public void Add(Staff staff){
            _context.Staffs.Add(staff);
            _context.SaveChanges();
        }
        public void Update(Staff staff){
            var existingStaff = _context.Staffs.Find(staff.StaffId);
            if (existingStaff != null)
            {
             existingStaff.StaffAssignedRole = staff.StaffAssignedRole;
             existingStaff.StaffId = staff.StaffId;   
             _context.SaveChanges();
            }
        }
        public void Delete(int id){
            var staff = _context.Staffs.Find(id);
            if (staff != null)
            {
                _context.Staffs.Remove(staff);
                _context.SaveChanges();
            }
        }
    }
}