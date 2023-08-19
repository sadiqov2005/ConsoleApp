using DomainLayer.Models;
using Repository.Data;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        private int _count = 1;
        public LocationService()
        {
            _locationRepository = new LocationRepository(); 
        }

        public void Create(Location location)
        {
            location.Id = _count;
            _locationRepository.Create(location);  
            _count++;

        }

        public bool Delete(int id)
        {
            var existLocation = AppDbContext<Location>.datas.FirstOrDefault(m => m.Id == id);
            if (existLocation != null)
            {
                AppDbContext<Location>.datas.Remove(existLocation);
                return true;

            }
            return false;
        }

        public bool Edit(int id, string newTitle, string newLatitude, string newLongitude)
        {
            var existPerson = AppDbContext<Location>.datas.FirstOrDefault(m => m.Id == id);
            if (existPerson != null)
            {
                existPerson.Longitude=newLongitude;
                existPerson.Latitude=newLatitude;
                existPerson.Title=newTitle;
                return true;
            }
            return false;   
        }

        public List<Location> GetAll()
        {
            return _locationRepository.GetAll();    
        }
    }
}
