using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class Piece
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Catalog { get; set; }
        public string Year { get; set; }
        public int Movements { get; set; }
        
        public Guid TonalityId { get; set; }
        public Tonality Tonality { get; set; }

        public Guid ComposerId { get; set; }
        public Composer Composer { get; set; }

        public IEnumerable<AudioRecording> AudioRecordings { get; set; }
        public IEnumerable<VideoRecording> VideoRecordings { get; set; }
        public IEnumerable<SheetMusic> SheetMusic { get; set; }
        //public IEnumerable<Instrument> Instruments { get; set; }
    }
}
