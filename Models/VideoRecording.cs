using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class VideoRecording
    {
        public Guid Id { get; set; }
        [Required]
        public string Url { get; set; }
        public string Performers { get; set; }
        public string Channel { get; set; }

        [Required]
        public Guid PieceId { get; set; }
        public Piece Piece { get; set; }
    }
}
