using AutoMapper;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Models.RelationshipEntities;
using ArtworkGallery.BLL.DTOs;

namespace ArtworkGallery.BLL.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Artwork, ArtworkDto>().ReverseMap();

            CreateMap<Artist, ArtistDto>().ReverseMap();

            CreateMap<Critique, CritiqueDto>().ReverseMap();

            CreateMap<Exhibition, ExhibitionDto>().ReverseMap();

            CreateMap<Gallery, GalleryDto>().ReverseMap();

            CreateMap<Owner, OwnerDto>().ReverseMap();

            CreateMap<Restoration, RestorationDto>().ReverseMap();

            CreateMap<Specialization, SpecializationDto>().ReverseMap();

            CreateMap<Staff, StaffDto>().ReverseMap();

            CreateMap<Transaction, TransactionDto>().ReverseMap();

            CreateMap<ArtworkExhibition, ArtworkExhibitionDto>().ReverseMap();

            CreateMap<OwnerTransaction, OwnerTransactionDto>().ReverseMap();
            
            CreateMap<SpecializationArtist, SpecializationArtistDto>().ReverseMap();

            CreateMap<StaffExhibition, StaffExhibitionDto>().ReverseMap(); }
    }
}