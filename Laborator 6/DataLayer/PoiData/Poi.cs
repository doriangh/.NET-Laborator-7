using System.ComponentModel.DataAnnotations;

namespace DataLayer.PoiData
{
    public class Poi
    {
        public Poi(int poiId, string name, string description, int cityId)
        {
            PoiId = poiId;
            Name = name;
            Description = description;
            CityId = cityId;
        }

        public int PoiId { get; set; }

        [Required(ErrorMessage = "You need to provide the POI name")]
        [MinLength(50)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to provide the POI description")]
        [MaxLength(150)]
        public string Description { get; set; }

        public int CityId { get; set; }
        public CityData.City City { get; private set; }
    }
}
