using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Data{
    [Table("images")]
    public class Image : Base {

        [Column("name")]
        public string Name {get; set;}
        [Column("size")]
        public double Size {get; set;}
        [Column("url")]
        public string Url {get; set;}  
    }
}