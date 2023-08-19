using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        void Create(Product product);
        List<Product> GeAll();
        bool Delete(int id );
        bool Edit(int id,string newDestription,string newName,double newPrice);
    }
}
