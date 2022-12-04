using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMRWebApi.Models
{
    public class Composer
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Period { get; set; }
        public string Birth { get; set; }
        public string Death { get; set; }
        [StringLength(5000)]
        [Column(TypeName = "varchar(5500)")]
        public string History { get; set; }
        public string ImgPath { get; set; }
    }
}
