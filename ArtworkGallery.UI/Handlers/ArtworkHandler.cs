using System;
using ArtworkGallery.BLL.Services;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Repositories;
using ArtworkGallery.DAL.Data;
using ArtworkGallery.UI.Enums;
using AutoMapper;

namespace ArtworkGallery.UI.Handlers
{
    public static class ArtworkHandler
    {
        public static void Handle(OperationType operation)
        {
            var context = new ApplicationDbContextFactory().CreateDbContext(); 
            var repository = new ArtworkRepository(context);
            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<ArtworkGallery.BLL.Mappings.MappingProfile>());
            var mapper = mapperConfig.CreateMapper();
            IArtworkService service = new ArtworkService(repository, mapper);

            switch (operation)
            {
                case OperationType.GetAll:
                    var artworks = service.GetAllArtworks();
                    foreach (var a in artworks)
                    {
                        Console.WriteLine(
                            $"ID: {a.ArtworkId}, Title: {a.Artworktitle}, Year: {a.ArtworkYearCreated}, " +
                            $"Medium: {a.Artworkmedium}, ArtistID: {a.ArtistId}, GalleryID: {a.GalleryId}, OwnerID: {a.OwnerId}");
                    }
                    break;

                case OperationType.GetById:
                    Console.Write("Enter Artwork ID: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        var artwork = service.GetArtworkById(id);
                        if (artwork != null)
                        {
                            Console.WriteLine(
                                $"ID: {artwork.ArtworkId}, Title: {artwork.Artworktitle}, Year: {artwork.ArtworkYearCreated}, " +
                                $"Medium: {artwork.Artworkmedium}, ArtistID: {artwork.ArtistId}, GalleryID: {artwork.GalleryId}, OwnerID: {artwork.OwnerId}");
                        }
                        else Console.WriteLine("Artwork not found.");
                    }
                    else Console.WriteLine("Invalid ID.");
                    break;

                case OperationType.Add:
                    var newArtwork = new ArtworkDto();

                    Console.Write("Title: ");
                    newArtwork.Artworktitle = Console.ReadLine() ?? "";

                    Console.Write("Year Created: ");
                    int.TryParse(Console.ReadLine(), out int year);
                    newArtwork.ArtworkYearCreated = year;

                    Console.Write("Medium: ");
                    newArtwork.Artworkmedium = Console.ReadLine() ?? "";

                    Console.Write("Artist ID: ");
                    int.TryParse(Console.ReadLine(), out int artistId);
                    newArtwork.ArtistId = artistId;

                    Console.Write("Gallery ID: ");
                    int.TryParse(Console.ReadLine(), out int galleryId);
                    newArtwork.GalleryId = galleryId;

                    Console.Write("Owner ID: ");
                    int.TryParse(Console.ReadLine(), out int ownerId);
                    newArtwork.OwnerId = ownerId;

                    service.AddArtwork(newArtwork);
                    Console.WriteLine("Artwork added.");
                    break;

                case OperationType.Update:
                    Console.Write("Enter Artwork ID to update: ");
                    if (int.TryParse(Console.ReadLine(), out int updateId))
                    {
                        var existing = service.GetArtworkById(updateId);
                        if (existing == null)
                        {
                            Console.WriteLine("Artwork not found.");
                            break;
                        }

                        Console.Write($"New Title (current: {existing.Artworktitle}): ");
                        var title = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(title)) existing.Artworktitle = title;

                        Console.Write($"New Year (current: {existing.ArtworkYearCreated}): ");
                        if (int.TryParse(Console.ReadLine(), out int newYear)) existing.ArtworkYearCreated = newYear;

                        Console.Write($"New Medium (current: {existing.Artworkmedium}): ");
                        var medium = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(medium)) existing.Artworkmedium = medium;

                        Console.Write($"New Artist ID (current: {existing.ArtistId}): ");
                        if (int.TryParse(Console.ReadLine(), out int newArtistId)) existing.ArtistId = newArtistId;

                        Console.Write($"New Gallery ID (current: {existing.GalleryId}): ");
                        if (int.TryParse(Console.ReadLine(), out int newGalleryId)) existing.GalleryId = newGalleryId;

                        Console.Write($"New Owner ID (current: {existing.OwnerId}): ");
                        if (int.TryParse(Console.ReadLine(), out int newOwnerId)) existing.OwnerId = newOwnerId;

                        service.UpdateArtwork(existing);
                        Console.WriteLine("Artwork updated.");
                    }
                    else Console.WriteLine("Invalid ID.");
                    break;

                case OperationType.Delete:
                    Console.Write("Enter Artwork ID to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        service.DeleteArtwork(deleteId);
                        Console.WriteLine("Artwork deleted.");
                    }
                    else Console.WriteLine("Invalid ID.");
                    break;

                default:
                    Console.WriteLine("Selected operation not implemented yet.");
                    break;
            }
        }
    }
}