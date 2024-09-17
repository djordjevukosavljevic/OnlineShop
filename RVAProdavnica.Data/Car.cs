using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FsCheck;

namespace RVAProdavnica.Data
{
    [Table("cars")]
    public class Car : Base
    {   
        [Column("brandName")]
        public string BrandName { get; set; }
        
        [Column("model")]
        public string Model { get; set; }
        
        public enum CarType {Coupe, Limousine , SUV}

        [Column("countryOrigin")]
        public string CountryOfOrigin { get; set; }

        [Column("year")]
        public int YearOfProduction { get; set; }
        
        [Column("price")]
        public double Price { get; set; }

      
    }
} 
