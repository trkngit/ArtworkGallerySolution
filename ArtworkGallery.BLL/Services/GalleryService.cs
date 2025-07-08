using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Interfaces;
using ArtworkGallery.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ArtworkGallery.BLL.Services
{
    public class GalleryService : IGalleryService
    {
        private readonly IGalleryRepository _galleryRepository;
        private readonly IMapper _mapper;

        public GalleryService(IGalleryRepository galleryRepository, IMapper mapper)
        {
            _galleryRepository = galleryRepository;
            _mapper = mapper;
        }

        public List<GalleryDto> GetAllGalleries() =>
            _mapper.Map<List<GalleryDto>>(_galleryRepository.GetAll());

        public GalleryDto? GetGalleryById(int id) =>
            _mapper.Map<GalleryDto>(_galleryRepository.GetById(id));

        public void AddGallery(GalleryDto galleryDto) =>
            _galleryRepository.Add(_mapper.Map<Gallery>(galleryDto));

        public void UpdateGallery(GalleryDto galleryDto) =>
            _galleryRepository.Update(_mapper.Map<Gallery>(galleryDto));

        public void DeleteGallery(int id) =>
            _galleryRepository.Delete(id);
    }
}