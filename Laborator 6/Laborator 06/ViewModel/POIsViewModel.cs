using System.ComponentModel.DataAnnotations;

namespace Laborator06.ViewModel
{
    public class POIsViewModel
    {
        public int PoiId { get; set; }

        [Required(ErrorMessage = "You need to provide the poi name")]
        [MinLength(50)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to provide the poi description")]
        [MaxLength(150)]
        public string Description { get; set; }


        public double CityId { get; set; }
        
    }
}
