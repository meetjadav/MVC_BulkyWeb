using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category ?Category { get; set; }
        public string? ImgURL {  get; set; }
    }
}
