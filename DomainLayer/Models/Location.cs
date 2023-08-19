using DomainLayer.Coomon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Location:BaseEntity
    {
        public string Title { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
