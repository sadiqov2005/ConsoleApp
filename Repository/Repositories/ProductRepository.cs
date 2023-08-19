using DomainLayer.Models;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(int Id, Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        void BaseRepository<Product>.Create(Product entity)
        {
            throw new NotImplementedException();
        }

        bool BaseRepository<Product>.Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        void BaseRepository<Product>.Edit(int Id, Product entity)
        {
            throw new NotImplementedException();
        }

        List<Product> BaseRepository<Product>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
