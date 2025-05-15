using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Data
{
    [Table("message")]
    public class Message
    {   
        [Column("email")]
        public String? email;
        [Column("text")]
        public String? Text;
    }
}