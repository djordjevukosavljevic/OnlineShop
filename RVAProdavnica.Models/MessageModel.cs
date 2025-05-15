using System.ComponentModel.DataAnnotations;

namespace RVAProdavnica.Models
{
    public class MessageModel
    {   
        [Key]
        public int Id { get; set; }

        public DateTime DateCreatedAt { get; set; }
        
        public DateTime DateUpdatedAt { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Text { get; set; }
    }
}