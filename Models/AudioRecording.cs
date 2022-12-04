using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class AudioRecording
    {
        public Guid Id { get; set; }
        [Required]
        public string AudioPath { get; set; }
        public string ImagePath { get; set; }
        public string Performers { get; set; }
        public string RecordLabel { get; set; }

        [Required]
        public Guid PieceId { get; set; }
        public Piece Piece { get; set; }
    }
}
