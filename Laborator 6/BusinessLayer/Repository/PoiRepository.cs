﻿using System.Collections.Generic;
using System.Linq;
using DataLayer.Management;
using DataLayer.PoiData;

namespace BusinessLayer.Repository
{
    public class PoiRepository : IPoiRepository
    {
        private ApplicationContext _context;

        public PoiRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void CreatePOI(Poi poi)
        {
            _context.Pois.Add(poi);
            _context.SaveChanges();
        }

        public void RemovePOI(int id)
        {
            var poiFirst = _context.Pois.First(c => c.PoiId == id);
            _context.Pois.Remove(poiFirst);
            _context.SaveChanges();
        }

        public void EditPOI(int id, Poi poi)
        {
            var dbPOI = _context.Pois.First(c => c.PoiId == id);
            dbPOI.PoiId = poi.PoiId;
            dbPOI.Name = poi.Name;
            dbPOI.Description = poi.Description;
            dbPOI.CityId = poi.CityId;
            _context.SaveChanges();

        }

        public Poi GetPoi(int id)
        {
            var poiFirst = _context.Pois.First(c => c.PoiId == id);
            return poiFirst;
        }

        public List<Poi> GetPois()
        {
            return _context.Pois.ToList();
        }
    }
}
