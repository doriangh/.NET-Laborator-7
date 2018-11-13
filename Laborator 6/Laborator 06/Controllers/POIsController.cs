using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repository;
using DataLayer.PoiData;
using Microsoft.AspNetCore.Mvc;

namespace Laborator_06.Controllers
{
    public class POIsController : Controller
    {
        private readonly IPoiRepository _repository;

        public POIsController(IPoiRepository repository)
        {
            _repository = repository;
        }

        public IActionResult GetAllPois()
        {
            var pois = _repository.GetPois();
            return View(pois);
        }
        public void CreatePOI(string name, string description, int cityId)
        {
            var id = _repository.GetPois().Count + 1;
            _repository.CreatePOI(new Poi(id, name, description, cityId));
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public void EditPoi(int poiId, string name, string description, int cityId)
        {
            _repository.EditPOI(poiId, new Poi(poiId ,name, description, cityId));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poi = _repository.GetPois().FirstOrDefault(m => m.PoiId == id);
            if (poi == null)
            {
                return NotFound();
            }

            return View(poi);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poi = _repository.GetPois().FirstOrDefault(m => m.PoiId == id);
            _repository.RemovePOI(id);

            return View(poi);
        }

        public IActionResult Index()
        {
            return View(_repository.GetPois().ToList());
        }
    }
}