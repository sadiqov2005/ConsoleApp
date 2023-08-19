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
    public class ProductService : IProductService
    {
        private int _count = 1;
        public void Create(Product product)
        {
            product.Id= _count;
          AppDbContext<Product>.datas.Add(product);
            _count++;   

        }

        public bool Delete(int id)
        {
           var existProduct= AppDbContext<Product>.datas.FirstOrDefault(m => m.Id ==id);
            if(existProduct != null)
            {
                AppDbContext<Product>.datas.Remove(existProduct);
                return true;

            }
            return false;
        }

        public bool Edit(int id, string newDestription, string newName, double newPrice)
        {
           var existProduct=AppDbContext<Product>.datas.FirstOrDefault(m=>m.Id ==id);
            if(existProduct != null)
            {
                existProduct.Description = newDestription;
                existProduct.Price = newPrice;  
                existProduct.Name= newName;
                return true;
            }
            return false;
        }

        public List<Product> GeAll()
        {
            return AppDbContext<Product>.datas;
        }
    }
}
