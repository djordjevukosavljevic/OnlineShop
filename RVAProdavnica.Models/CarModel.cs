using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        
        public string Manufacturer { get; set; }

        public string ModelName { get; set; }

        public string CountryOfOrigin { get; set; }

        public int YearOfProduction { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }   

        public DateTime DateCreatedAt { get; set; }

        public DateTime DateUpdatedAt { get; set; }
    
        public string Description { get; set; }
    
    }
}
