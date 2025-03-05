using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Models
{
    public class UserModel
    {
        
     
        [Key]
        public int Id { get; set; }
        
        public DateTime DateCreatedAt { get; set; }

        public DateTime DateUpdatedAt { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username {get;set;}
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Role role {get;set;}

        public enum Role { ADMIN, PREMIUM_USER, USER }
        
    }

}