using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Data
{
    [Table("bugs")]
    public class BugReport : Base
    {

        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }

        [Column("code")]
        public string BugCode { get; set; }

    }
}
