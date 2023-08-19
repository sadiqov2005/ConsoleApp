using DomainLayer.Coomon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Product: BaseEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


    }
}
