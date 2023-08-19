using DomainLayer.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsolAppFinelProject.Controller
{
    public  class ProductController
    {
        private readonly IProductService _productService;
        public ProductController()
        {
               _productService=new ProductService();
        }


        public void Create()
        {
            Console.Write("Add product description;");
            string description=Console.ReadLine();
            if (string.IsNullOrEmpty(description.Trim()))
            {
                Console.WriteLine("Duzgun girin!!! ");
            }

            Console.Write("Add product name:");
            string name=Console.ReadLine();
            if (string.IsNullOrEmpty(name.Trim()))
            {
                Console.WriteLine("Duzgun girin!!! ");
            }
            Console.Write("Add product price:");
            priceLabel:  double price=Convert.ToDouble(Console.ReadLine());
            if (price <=0)
            {
                Console.WriteLine("Add price correctly !!!");
                goto priceLabel;
            }

            Product product = new()
            {
                Name = name,
                Description = description,
                Price = price
            };

            _productService.Create(product);
            Console.WriteLine("Product added seccessfully ");
        }


        public void GetAll()
        {
            foreach (var item in _productService.GeAll())
            {

                string data = $"Product description:{item.Description}, Name:{item.Name}, Price:{item.Price}";
                Console.WriteLine(data);
            }
        }




        public void Delete()
        {
            Console.Write("Enter id of product that you want to delete ");
            idlabel:   string id = Console.ReadLine();
            int selectedId;
            bool isTrue=int.TryParse(id, out selectedId);
            if (!isTrue)
            {
                Console.WriteLine(" Enter correctly !!!");
                goto idlabel;

            }
            bool result = _productService.Delete(selectedId);

            if (!result)
            {
                Console.WriteLine("There are  no products in this id, choose again and correctly!");
                goto idlabel;
            }
            else
            {
                _productService.Delete(selectedId);
                Console.WriteLine("Product deleted successfully ");
            }
        }




        public void Edit()
        {
            Console.Write("Enter id of product that you want to edit: ");
            idLabel:   string id=Console.ReadLine();
            int selectedId;
            bool isTrue=int.TryParse(id, out selectedId);
            if (!isTrue)
            {
                Console.WriteLine("Enter correctly!!!!");
                goto idLabel;
            }

            Console.Write("Enter new description:");
            newDescriptionLabel: string newDescription=Console.ReadLine();
            if (string.IsNullOrEmpty(newDescription.Trim()))
            {
                Console.WriteLine("Enter correctly ");
                goto newDescriptionLabel;
            }
            Console.Write("Enter new name:");
            newNameLabel: string newName=Console.ReadLine();
            if (string.IsNullOrEmpty(newName.Trim()))
            {
                Console.WriteLine("Enter correctly ");
                goto newNameLabel;
            }

            Console.Write("Enter new price: ");
            newPriceLabel:   double newPrice=Convert.ToDouble(Console.ReadLine());
            if (newPrice<=0)
            {
                Console.WriteLine("Enter correctly price must be greater than 0");
                goto newPriceLabel;
            }

            bool result = _productService.Edit(selectedId, newDescription,  newName,newPrice);
            if (!result)
            {
                Console.WriteLine("It couldnt find there are no product in that id");
                goto idLabel;
            }
            else
            {
                _productService.Edit(selectedId, newDescription, newName, newPrice);
                Console.WriteLine("Edit is success");
            }

        }





    }
}
