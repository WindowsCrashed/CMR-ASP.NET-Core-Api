using CMRWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CMRWebApi.Infrastructure
{
    public class CMRDbContext : DbContext
    {
        public DbSet<Composer> Composers { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<AudioRecording> AudioRecordings { get; set; }
        public DbSet<VideoRecording> VideoRecordings { get; set; }
        public DbSet<SheetMusic> SheetMusic { get; set; }
        public DbSet<Tonality> Tonality { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<InstrumentPiece> InstrumentPieces { get; set; }

        public CMRDbContext(DbContextOptions<CMRDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<InstrumentPiece>()
                .HasKey(ip => new { ip.InstrumentId, ip.PieceId });
        }
    }
}
