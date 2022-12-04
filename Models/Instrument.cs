using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class Instrument
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        //[Required]
        //public Guid PieceId { get; set; }
        //public Piece Piece { get; set; }

        public IEnumerable<Piece> Pieces { get; set; }
    }
}
