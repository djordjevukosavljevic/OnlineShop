using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Models
{
    public class BugReportModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime? DateCreatedAt { get; set; }

        public DateTime? DateUpdatedAt { get; set; }

        public bool? Active { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string BugCode { get; set; }
    }
}
