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
        //public DbSet<Instrument> Instruments { get; set; }

        public CMRDbContext(DbContextOptions<CMRDbContext> options) : base(options) { }
    }
}
