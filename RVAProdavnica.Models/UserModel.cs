using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Models
{
    public class UserModel
    {
        
        [Column("id")]
        [Key]
        public int Id { get; set; }
      
        [Column("username")]
        public string Username { get; set; }
     
        [Column("password")]
        public string Password { get; set; }
        
        
    }

}