using DomainLayer.Models;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
        public void Create(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(int Id, Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
