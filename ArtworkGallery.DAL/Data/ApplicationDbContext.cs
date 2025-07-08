using Microsoft.EntityFrameworkCore;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.DAL.Models.RelationshipEntities;

namespace ArtworkGallery.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Critique> Critiques { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Restoration> Restorations { get; set; }

        // Relationship entities
        public DbSet<StaffExhibition> StaffExhibitions { get; set; }
        public DbSet<ArtworkExhibition> ArtworkExhibitions { get; set; }
        public DbSet<OwnerTransaction> OwnerTransactions { get; set; }
        public DbSet<SpecializationArtist> SpecializationArtists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Composite key definitions for relationship entities
            modelBuilder.Entity<ArtworkExhibition>()
                .HasKey(ae => new { ae.ArtworkId, ae.ExhibitionId });

            modelBuilder.Entity<OwnerTransaction>()
                .HasKey(ot => new { ot.TransactionId, ot.OwnerId });

            modelBuilder.Entity<SpecializationArtist>()
                .HasKey(sa => new { sa.SpecializationId, sa.ArtistId });

            modelBuilder.Entity<StaffExhibition>()
                .HasKey(se => new { se.StaffId, se.ExhibitionId });
        }
    }
}