using System.ComponentModel.DataAnnotations;

namespace RVAProdavnica.Models
{
    public class ImageModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreatedAt { get; set; }

        public DateTime DateUpdatedAt { get; set; }

        public bool Active { get; set; }

        [Required]
        public string Name { get; set; }

        public double Size { get; set; }
        [Required]
        public string Path { get; set; }
    }
}