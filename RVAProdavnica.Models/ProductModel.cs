using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Models
{
    public class ProductModel 
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreatedAt { get; set; }

        public DateTime DateUpdatedAt { get; set; }

        public bool Active { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public string imagePath { get; set; }
    }
}