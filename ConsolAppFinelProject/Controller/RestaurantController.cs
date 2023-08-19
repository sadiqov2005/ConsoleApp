using DomainLayer.Models;
using Microsoft.VisualBasic;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppFinelProject.Controller
{
    public class RestaurantController
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantController()
        {
            _restaurantService = new RestaurantService();
        }

        public void Create()
        {
            Console.Write("Add restaurant  tittle:");
        restaurantTitle:
            string title = Console.ReadLine();
            if (string.IsNullOrEmpty(title.Trim()))
            {
                Console.WriteLine("Duzgun girin! ");
                goto restaurantTitle;
            }

            Console.Write("Add restaurant  descrition :");
        restaurantDescription:
            string description = Console.ReadLine();
            if (string.IsNullOrEmpty(description.Trim()))
            {
                Console.WriteLine("Duzgun girin! ");
                goto restaurantDescription;
            }

            Console.Write("Add restaurant  Reastaurant:");
        restauranLocation:
            string location = Console.ReadLine();
            if (string.IsNullOrEmpty(location.Trim()))
            {
                Console.WriteLine("Duzgun girin! ");
                goto restauranLocation;
            }


            Restaurant  restaurant  = new()
            {
                Title = title,
                Description = description,
                Location = location
            };
          _restaurantService.Create(restaurant);
            Console.WriteLine("restaurant  added is success");
        }



        public void GetAll()
        {

            foreach (var item in _restaurantService.GetAll())
            {
                string data = $"{item.Id}~ Restaurant title:{item.Title}, Description:{item.Description},  Location:{item.Location}";
                Console.WriteLine(data);
            }
        }


        public void Edit()
        {

            Console.Write("Enter id of restaurant  that you want to edit ");
        IdLabel: string id = Console.ReadLine();

            int selectedId;
            bool isTrue = int.TryParse(id, out selectedId);
            if (!isTrue)
            {
                Console.WriteLine("Enter correctly !!!");
                goto IdLabel;
            }

            Console.Write("Enter new  title:");
        newTitle: string newTitle = Console.ReadLine();
            if (string.IsNullOrEmpty(newTitle.Trim()))
            {
                Console.WriteLine("Enter correctly!!!");
                goto newTitle;
            }

            Console.Write("Enter new descriotion : ");
        newDescriotion: string newDescriotion = Console.ReadLine();
            if (string.IsNullOrEmpty(newDescriotion.Trim()))
            {
                Console.WriteLine("Enter correctly !!!");
                goto newDescriotion;
            }

            Console.Write("Enter new location: ");
        newLocation: string newLocation = Console.ReadLine();
            if (string.IsNullOrEmpty(newLocation.Trim()))
            {
                Console.WriteLine("Enter correctly !!!");
                goto newLocation;
            }

            bool result = _restaurantService.Edit(selectedId,newTitle,newDescriotion,newLocation );
            if (!result)
            {
                Console.WriteLine("It couldnt find there are no locations in that id ");
                goto IdLabel;
            }
            else
            {
                _restaurantService.Edit(selectedId, newTitle, newDescriotion, newLocation);
                Console.WriteLine("Edit is succes");
            }
        }



        public void Delete()
        {
            GetAll();
            Console.Write("Enter id of restaurant that you want to delete: ");
            idLabel: string id=Console.ReadLine();
            int selectedId;

           bool isTrue=int.TryParse(id, out selectedId);    

            if (!isTrue)
            {
                Console.WriteLine("Duzgun giri!!!");
                goto idLabel;
            }

            bool result =_restaurantService.Delete(selectedId); 
            if (!result)
            {
                Console.WriteLine("There are  no restaurant  in this id, choose again and correctly!");
                goto idLabel;
            }
            else
            {
                _restaurantService.Delete(selectedId);
                Console.WriteLine("Restaurant deleted successfully ");
            }
        }
    }
}
