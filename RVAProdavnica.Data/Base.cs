using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Data
{
    public class Base
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("date_created_at")]
        public DateTime DateCreatedAt { get; set; }
        
        [Column("date_updated_at")]
        public DateTime DateUpdatedAt { get; set; }

        [Column("active")]
        public bool Active { get; set; }

    }
}
