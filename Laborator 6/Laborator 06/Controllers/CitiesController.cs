using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repository;
using DataLayer.CityData;
using Microsoft.AspNetCore.Mvc;

namespace Laborator_06.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICityRepository _repository;

        public CitiesController(ICityRepository repository)
        {
            _repository = repository;
        }

        public IActionResult GetAllCities()
        {
            var cities = _repository.GetCities();
            return View(cities);
        }
        public void CreateCity(string Name, string Description, float Latitude, float Longitude)
        {
            var id = _repository.GetCities().Count + 1;
            _repository.CreateCity(new City(id, Name, Description, Latitude, Longitude));
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public void EditCity(int CityId, string Name, string Description, float Latitude, float Longitude)
        {
            _repository.EditCity(CityId, new City(CityId, Name, Description, Latitude, Longitude));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = _repository.GetCities().FirstOrDefault(m => m.CityId == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = _repository.GetCities().FirstOrDefault(m => m.CityId == id);
            _repository.RemoveCity(id);

            return View(city);
        }

        public IActionResult Index()
        {
            return View(_repository.GetCities().ToList());
        }
    }
}