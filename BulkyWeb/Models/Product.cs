using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ISBN { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Author { get; set; }
        [Required]
        public double? Price { get; set; }

    }
}
