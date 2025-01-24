using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Data 
{

    // [Table("reviews")]
    public class Review : Base
    {   
        // [Column("grade")]
        public int Grade {get; set;}
        // [Column("description")]
        public String Description{get; set;}
        public String Reply {get; set;}
        // [Column("user")]
        public User User {get; set;}

    }
}