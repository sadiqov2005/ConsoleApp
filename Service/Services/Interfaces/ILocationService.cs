using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.Services.Interfaces
{
    public interface ILocationService
    {
        void Create(Location location);
        List<Location> GetAll();
        bool Edit(int id,string newTitle,string newLatitude,string newLongitude);
        bool Delete(int id);
     
    }
}
