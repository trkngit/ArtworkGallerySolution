﻿// <auto-generated />
using System;
using ArtworkGallery.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArtworkGallery.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("ArtistBio")
                        .HasColumnType("text");

                    b.Property<int>("ArtistBirthYear")
                        .HasColumnType("integer");

                    b.Property<string>("ArtistCountry")
                        .HasColumnType("text");

                    b.Property<string>("ArtistName")
                        .HasColumnType("text");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Artwork", b =>
                {
                    b.Property<int>("ArtworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ArtworkId"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("integer");

                    b.Property<int>("ArtworkYearCreated")
                        .HasColumnType("integer");

                    b.Property<string>("Artworkmedium")
                        .HasColumnType("text");

                    b.Property<string>("Artworktitle")
                        .HasColumnType("text");

                    b.Property<int>("GalleryId")
                        .HasColumnType("integer");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.HasKey("ArtworkId");

                    b.ToTable("Artworks");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Critique", b =>
                {
                    b.Property<int>("CritiqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CritiqueId"));

                    b.Property<int>("ArtworkId")
                        .HasColumnType("integer");

                    b.Property<string>("CritiqueComment")
                        .HasColumnType("text");

                    b.Property<DateTime>("CritiqueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CritiqueName")
                        .HasColumnType("text");

                    b.Property<int>("CritiqueRating")
                        .HasColumnType("integer");

                    b.HasKey("CritiqueId");

                    b.ToTable("Critiques");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Exhibition", b =>
                {
                    b.Property<int>("ExhibitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ExhibitionId"));

                    b.Property<string>("ExhibitionLocation")
                        .HasColumnType("text");

                    b.Property<string>("ExhibitionName")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExhibitionStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExhibitonEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GalleryId")
                        .HasColumnType("integer");

                    b.HasKey("ExhibitionId");

                    b.ToTable("Exhibitions");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Gallery", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GalleryId"));

                    b.Property<string>("GalleryAddress")
                        .HasColumnType("text");

                    b.Property<string>("GalleryManager")
                        .HasColumnType("text");

                    b.Property<string>("GalleryName")
                        .HasColumnType("text");

                    b.Property<string>("GalleryPhone")
                        .HasColumnType("text");

                    b.HasKey("GalleryId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OwnerId"));

                    b.Property<string>("OwnerContactInfo")
                        .HasColumnType("text");

                    b.Property<string>("OwnerName")
                        .HasColumnType("text");

                    b.Property<string>("OwnerType")
                        .HasColumnType("text");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.RelationshipEntities.ArtworkExhibition", b =>
                {
                    b.Property<int>("ArtworkId")
                        .HasColumnType("integer");

                    b.Property<int>("ExhibitionId")
                        .HasColumnType("integer");

                    b.HasKey("ArtworkId", "ExhibitionId");

                    b.ToTable("ArtworkExhibitions");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.RelationshipEntities.OwnerTransaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .HasColumnType("integer");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("TransactionId", "OwnerId");

                    b.ToTable("OwnerTransactions");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.RelationshipEntities.SpecializationArtist", b =>
                {
                    b.Property<int>("SpecializationId")
                        .HasColumnType("integer");

                    b.Property<int>("ArtistId")
                        .HasColumnType("integer");

                    b.HasKey("SpecializationId", "ArtistId");

                    b.ToTable("SpecializationArtists");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.RelationshipEntities.StaffExhibition", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("integer");

                    b.Property<int>("ExhibitionId")
                        .HasColumnType("integer");

                    b.HasKey("StaffId", "ExhibitionId");

                    b.ToTable("StaffExhibitions");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Restoration", b =>
                {
                    b.Property<int>("RestorationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RestorationId"));

                    b.Property<int>("ArtworkId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RestorationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RestorationNotes")
                        .HasColumnType("text");

                    b.Property<string>("RestorerName")
                        .HasColumnType("text");

                    b.HasKey("RestorationId");

                    b.ToTable("Restorations");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Specialization", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SpecializationId"));

                    b.Property<string>("SpecializationGenre")
                        .HasColumnType("text");

                    b.Property<string>("SpecializationMediumType")
                        .HasColumnType("text");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StaffId"));

                    b.Property<string>("StaffAssignedRole")
                        .HasColumnType("text");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("ArtworkGallery.DAL.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TransactionId"));

                    b.Property<int>("ArtworkId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TransactionSaleDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("TransactionSalePrice")
                        .HasColumnType("numeric");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
