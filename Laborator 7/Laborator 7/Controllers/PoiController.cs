using System.Collections.Generic;
using BusinessLayer.Repository;
using DataLayer.PoiData;
using Microsoft.AspNetCore.Mvc;

namespace Laborator_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoiController : ControllerBase
    {
        private readonly IPoiRepository _repository;

        public PoiController(IPoiRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Poi
        [HttpGet]
        public ActionResult<List<Poi>> Get()
        {
            return _repository.GetPois();
        }

        // GET: api/Poi/5
        [HttpGet("{id}")]
        public ActionResult<Poi> Get(int id)
        {
            return _repository.GetPoi(id);
        }

        // POST: api/Poi
        [HttpPost]
        public void Post([FromBody] Poi poi)
        {
            _repository.CreatePOI(poi);
        }

        // PUT: api/Poi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Poi poi)
        {
            _repository.EditPOI(id, poi);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.RemovePOI(id);
        }
    }
}
