using DomainLayer.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace ConsolAppFinelProject.Controller
{
    public  class LocationController
    {
        private readonly ILocationService _locationService;
        public LocationController()
        {
            _locationService=new LocationService();    
        }


        public void Create ()
        {
            Console.Write("Add Location tittle:");
            locationTitle:
            string title = Console.ReadLine();
            if (string.IsNullOrEmpty(title.Trim()))
            {
                Console.WriteLine("Duzgun girin! ");
                goto locationTitle;
            }

            Console.Write("Add location latitude:");
            locationLatitude:
            string latitude=Console.ReadLine();
            if (string.IsNullOrEmpty(latitude.Trim()))
            {
                Console.WriteLine("Duzgun girin! ");
                goto locationLatitude;
            }

            Console.Write("Add location longitude:");
            locationLongitude:
            string longitude=Console.ReadLine();
            if (string.IsNullOrEmpty(longitude.Trim()))
            {
                Console.WriteLine("Duzgun girin! ");
                goto locationLongitude;
            }

            Location location = new()
            {
                Title = title,
                Latitude = latitude,
                Longitude = longitude

            };
            _locationService.Create(location);
            Console.WriteLine("Location added is success");
        }

        public void GetAll()
        {
            foreach (var item in _locationService.GetAll())
            {
                string data = $"Location Tittle:{item.Title} Longitude:{item.Longitude} Latitude:{item.Latitude}";
                Console.WriteLine(data);
            }
        }


        public void Edit()
        {
            Console.WriteLine("Enter id of location that you want to edit ");
        IdLabel: string id = Console.ReadLine();

            int selectedId;
            bool isTrue = int.TryParse(id, out selectedId);
            if (!isTrue)
            {
                Console.WriteLine("Enter correctly !!!");
                goto IdLabel;
            }

            Console.WriteLine("Enter new  title:");
        newTitle: string newTitle = Console.ReadLine();
            if (string.IsNullOrEmpty(newTitle.Trim()))
            {
                Console.WriteLine("Enter correctly!!!");
                goto newTitle;
            }

            Console.WriteLine("Enter new latitude : ");
        newLatitude: string newLatitude = Console.ReadLine();
            if (string.IsNullOrEmpty(newLatitude.Trim()))
            {
                Console.WriteLine("Enter correctly !!!");
                goto newLatitude;
            }

            Console.WriteLine("Enter new logitude: ");
        newLongitude: string newLongitude = Console.ReadLine();
            if (string.IsNullOrEmpty(newLongitude.Trim()))
            {
                Console.WriteLine("Enter correctly !!!");
                goto newLongitude;
            }

            bool result = _locationService.Edit(selectedId, newLatitude, newLongitude,newTitle);
            if (!result)
            {
                Console.WriteLine("It couldnt find there are no locations in that id ");
                goto IdLabel;
            }
            else
            {
                _locationService.Edit(selectedId,newTitle,newLatitude,newLongitude);
                Console.WriteLine("Edit is succes");
            }
        }
        


        public void Delete()
        {
            GetAll();

            Console.WriteLine("Enter  location id that you want to delete");
        IdLabel: string id = Console.ReadLine();
            int selectedId;
            bool isTrue = int.TryParse(id, out selectedId);

            if (!isTrue)
            {

                Console.WriteLine("Enter correctly !!!");
                goto IdLabel;
            }

            bool result = _locationService.Delete(selectedId);

            if (!result)
            {
                Console.WriteLine("There are  no locations in this id, choose again and correctly!");
                goto IdLabel;
            }
            else
            {
                _locationService.Delete(selectedId);
                Console.WriteLine("location deleleted is success");
            }
        }
    }
}
