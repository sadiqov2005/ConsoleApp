using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public  interface IRestaurantService
    {
        public void Create(Restaurant restaurant);
        List<Restaurant> GetAll();
        bool Edit(int id,string newTitle,string newDescription,string newLocation);
        public bool Delete(int id); 
    }
}
