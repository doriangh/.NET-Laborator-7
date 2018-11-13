using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.CityData
{
    public class City
    {
        public City()
        {
        }

        public City(int cityId, string name, string description, double latitude, double longitude)
        {
            CityId = cityId;
            Name = name;
            Description = description;
            Latitude = latitude;
            Longitude = longitude;
        }

        public int CityId { get; set; }

        [Required(ErrorMessage = "You need to provide the city name")]
        [MinLength(50)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to provide the city description")]
        [MaxLength(150)]
        public string Description { get; set; }

        public ICollection<PoiData.Poi> Pois { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }


    }
}
