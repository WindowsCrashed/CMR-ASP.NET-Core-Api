using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class InstrumentPiece
    {
        [Required]
        public Guid InstrumentId { get; set; }
        public Instrument Instrument { get; set; }

        [Required]
        public Guid PieceId { get; set; }
        public Piece Piece { get; set; }
    }
}
