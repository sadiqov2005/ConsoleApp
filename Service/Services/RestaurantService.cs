using DomainLayer.Models;
using Repository.Data;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RestaurantService : IRestaurantService
    {
        private int _count = 1;
        public void Create(Restaurant restaurant)
        {
            restaurant.Id = _count;
            AppDbContext<Restaurant>.datas.Add(restaurant);
            _count++;   
        }

        public bool Delete(int id)
        {
            var existRestaurant=AppDbContext<Restaurant>.datas.FirstOrDefault(x => x.Id == id); 
            if(existRestaurant != null)
            {
                AppDbContext<Restaurant>.datas.Remove(existRestaurant);
                return true;

            }
            return false;
        }

        public bool Edit(int id, string newTitle, string newDescription, string newLocation)
        {
           var existRestaurant=AppDbContext<Restaurant>.datas.FirstOrDefault(m=>m.Id == id);
            if(existRestaurant != null)
            {
                existRestaurant.Title = newTitle;
                existRestaurant.Description = newDescription;
                existRestaurant.Location = newLocation;
                return true;
            }
            return false;
        }

        public List<Restaurant> GetAll()
        {
          return AppDbContext<Restaurant>.datas.ToList();
        }


     
    }
}
