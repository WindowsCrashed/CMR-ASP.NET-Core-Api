using CMRWebApi.Models;

namespace CMRWebApi.Dto
{
    public class PieceDetailedDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Catalog { get; set; }
        public string Year { get; set; }
        public int Movements { get; set; }
        public string Tonality { get; set; }

        public ComposerDto Composer { get; set; }

        public IEnumerable<AudioRecordingDto> AudioRecordings { get; set; }
        public IEnumerable<VideoRecordingDto> VideoRecordings { get; set; }
        public IEnumerable<SheetMusicDto> SheetMusic { get; set; }
        public IEnumerable<InstrumentDto> Instruments { get; set; }
    }
}
