using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Data
{
    [Table("users")]
    public class User : Base
    {
        [Column("name")]
        public string? Name { get; set; }
        [Column("lastname")]
        public string? Lastname { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("password")]
        public string? Password { get; set; }

        public enum Role { ADMIN, PREMIUM_USER, USER}
    }

}
