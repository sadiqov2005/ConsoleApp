using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Restaurant
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public List<string> Menu { get; set; }

        

    }
}
