using System.ComponentModel.DataAnnotations;
namespace Laborator_7.Models
{
    public class UpdateCityModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        
    }
}