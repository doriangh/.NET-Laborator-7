using System;
using System.ComponentModel.DataAnnotations;
namespace Laborator_7.Models

{
    public class CreateCityModel
    {
        public int CityId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
    }
}