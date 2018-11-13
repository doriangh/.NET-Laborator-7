using System.ComponentModel.DataAnnotations;

namespace Laborator06.ViewModel
{
    public class CitiesViewModel
    {
        public int CityId { get; set; }

        [Required(ErrorMessage = "You need to provide the city name")]
        [MinLength(50)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to provide the city description")]
        [MaxLength(150)]
        public string Description { get; set; }


        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
