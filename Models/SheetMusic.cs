using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class SheetMusic
    {
        public Guid Id { get; set; }
        [Required]
        public string Url { get; set; }

        [Required]
        public Guid PieceId { get; set; }
        public Piece Piece { get; set; }
    }
}
