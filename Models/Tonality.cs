using System.ComponentModel.DataAnnotations;

namespace CMRWebApi.Models
{
    public class Tonality
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IEnumerable<Piece> Pieces { get; set; }
    }
}
