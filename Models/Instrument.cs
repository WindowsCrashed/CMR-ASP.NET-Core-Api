using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class Instrument
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IEnumerable<InstrumentPiece> InstrumentPieces { get; set; }
    }
}
