using ArtworkGallery.DAL.Data;
using ArtworkGallery.BLL.Services;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ArtworkGallery.BLL.Mappings;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Services and Repositories
builder.Services.AddScoped<IArtworkService, ArtworkService>();
builder.Services.AddScoped<IArtworkRepository, ArtworkRepository>();

builder.Services.AddScoped<IArtistService, ArtistService>();
builder.Services.AddScoped<IArtistRepository, ArtistRepository>();

builder.Services.AddScoped<IGalleryService, GalleryService>();
builder.Services.AddScoped<IGalleryRepository, GalleryRepository>();

builder.Services.AddScoped<IExhibitionService, ExhibitionService>();
builder.Services.AddScoped<IExhibitionRepository, ExhibitionRepository>();

builder.Services.AddScoped<ICritiqueService, CritiqueService>();
builder.Services.AddScoped<ICritiqueRepository, CritiqueRepository>();

builder.Services.AddScoped<IRestorationService, RestorationService>();
builder.Services.AddScoped<IRestorationRepository, RestorationRepository>();

builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<IStaffRepository, StaffRepository>();

builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

builder.Services.AddScoped<IOwnerService, OwnerService>();
builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();

builder.Services.AddScoped<IOwnerTransactionService, OwnerTransactionService>();
builder.Services.AddScoped<IOwnerTransactionRepository, OwnerTransactionRepository>();

builder.Services.AddScoped<ISpecializationService, SpecializationService>();
builder.Services.AddScoped<ISpecializationRepository, SpecializationRepository>();

builder.Services.AddScoped<ISpecializationArtistService, SpecializationArtistService>();
builder.Services.AddScoped<ISpecializationArtistRepository, SpecializationArtistRepository>();

builder.Services.AddScoped<IArtworkExhibitionService, ArtworkExhibitionService>();
builder.Services.AddScoped<IArtworkExhibitionRepository, ArtworkExhibitionRepository>();

builder.Services.AddScoped<IStaffExhibitionService, StaffExhibitionService>();
builder.Services.AddScoped<IStaffExhibitionRepository, StaffExhibitionRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();