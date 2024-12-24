using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Data
{
    [Table("message")]
    public class Message
    {   
        [Column("user")]
        public User User;
        [Column("size")]
        public double Size;
        [Column("text")]
        public String Text;
    }
}