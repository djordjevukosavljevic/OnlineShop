using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Data
{
    [Table("message")]
    public class Message : Base
    {   
        [Column("name")]
        public string? Name { get; set; }
        [Column("lastname")]
        public string? Lastname { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("subject")]
        public string? Subject { get; set; }
        [Column("textMessage")]
        public string? TextMessage { get; set; }
    }
}