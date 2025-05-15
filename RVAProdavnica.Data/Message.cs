using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Data
{
    [Table("message")]
    public class Message : Base
    {   
        [Column("email")]
        public string? Email { get; set; }
        [Column("text")]
        public string? Text { get; set; }
    }
}