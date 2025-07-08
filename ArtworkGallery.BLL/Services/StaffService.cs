using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IMapper _mapper;

        public StaffService(IStaffRepository staffRepository, IMapper mapper)
        {
            _staffRepository = staffRepository;
            _mapper = mapper;
        }

        public List<StaffDto> GetAllStaff()
        {
            var staff = _staffRepository.GetAll();
            return _mapper.Map<List<StaffDto>>(staff);
        }

        public StaffDto? GetStaffById(int id)
        {
            var staff = _staffRepository.GetById(id);
            return _mapper.Map<StaffDto>(staff);
        }

        public void AddStaff(StaffDto staffDto)
        {
            var staff = _mapper.Map<Staff>(staffDto);
            _staffRepository.Add(staff);
        }

        public void UpdateStaff(StaffDto staffDto)
        {
            var staff = _mapper.Map<Staff>(staffDto);
            _staffRepository.Update(staff);
        }

        public void DeleteStaff(int id)
        {
            _staffRepository.Delete(id);
        }
    }
}