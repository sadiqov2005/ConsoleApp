
using ConsolAppFinelProject.Controller;

LocationController locationController = new LocationController();
RestaurantController restaurantController = new RestaurantController();
ProductController productController = new ProductController();      
bool isFinished = true;
mainMenu:
while (true)
{
  
    Console.WriteLine("Proqrama xos gelmisiniz");
    Console.WriteLine();
    Console.WriteLine("Ana menu");
    Console.WriteLine("1.Location emeliyyatlari");
    Console.WriteLine("2.Restoran emeliyyatlari");
    Console.WriteLine("3.Product  emeliyyatlari");
    Console.WriteLine("4. Cixis");
    Console.Write("Secin: ");
    enterenceChoice:   string enterenceChoice = Console.ReadLine();
    int selectedEnterenceChoice;
    bool isTrueEnterenceChoice=int.TryParse(enterenceChoice, out selectedEnterenceChoice); 

    if(isTrueEnterenceChoice)
    {
        switch (selectedEnterenceChoice)
        {
            case 1:
                Console.WriteLine("Location emeliyyetlari: ");
                Console.WriteLine("1.Yeni location elave etmek ");
                Console.WriteLine("2.Locationa duzeltme etmek.");
                Console.WriteLine("3.Location silmek .");
                Console.WriteLine("4.Location siralamaq .");
                Console.WriteLine("5.Ana menuya geri donmek ");
                Console.Write("Secin: ");

                locationChoice:   string locationChoice=Console.ReadLine();
                int selectedLocationChoice;
                bool isTrueLocationChoice=int.TryParse(locationChoice, out selectedLocationChoice);
                if (isTrueLocationChoice)
                {
                    switch(selectedLocationChoice)
                    {
                        case 1:
                            locationController.Create();
                            break;
                        case 2:
                            locationController.Edit();
                            break;
                            case 3:
                            locationController.Delete();
                            break;
                            case 4:
                            locationController.GetAll();
                            goto mainMenu;
                            case 5:
                            goto mainMenu;
                     
                          
                        default:
                            Console.WriteLine("Duzgun secin !!!");
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Duzgun secin !!!");
                    goto locationChoice;
                }
                break;
                case 2:
                Console.WriteLine("Restoran emeliyyatlari");

                Console.WriteLine("1.Yeni restoran elave etmek ");
                Console.WriteLine("2.Restorana duzeltme etmek ");
                Console.WriteLine("3.Retoran silmek ");
                Console.WriteLine("4.Retoran menu emeliyyatlari ");
                Console.WriteLine("5.Retoran siralama  ");
                Console.WriteLine("6.Ana menuya geri donmek   ");

                restaurantChoice:  string restaurantChoice=Console.ReadLine();
                int selectedRestaurantChoice;
                bool isTrueRestaurantChoice=int.TryParse(restaurantChoice, out selectedRestaurantChoice);
                if (isTrueRestaurantChoice)
                {
                    switch (selectedRestaurantChoice)
                    {
                        case 1:
                            restaurantController.Create();
                            break;
                        case 2:
                            restaurantController.Edit();
                            break;
                        case 3:
                           restaurantController.Delete();
                            break;
                        case 4:
                            Console.WriteLine("Restoran menu emeliyyatlari");
                            break;
                        case 5:
                            restaurantController.GetAll();
                            break;
                        case 6:
                            goto mainMenu;
                        default:
                            Console.WriteLine("Duzgun secin !!! ");
                            break;



                    }
                }
                else
                {
                    Console.WriteLine("Duzgun secin!!!");
                    goto restaurantChoice;
                }
                break;
                case 3:
                Console.WriteLine("Product  emeliyyatlari");
                Console.WriteLine();
                Console.WriteLine("1.Yeni product elave etmek");
                Console.WriteLine("2.Product duzeltme etmek ");
                Console.WriteLine("3.Product silmek");
                Console.WriteLine("4.Product siralamq");
                Console.WriteLine("5.Ana menuya geri donmek ");

                string productChoice=Console.ReadLine();
                int selectedProductChoice;
                selectedProductChoice:
                bool istrueSelectedProductChoice=int.TryParse(productChoice, out selectedProductChoice);
                if (!istrueSelectedProductChoice)
                {
                    Console.WriteLine("Duzgun girin !!!");
                    goto selectedProductChoice;
                }
                switch (selectedProductChoice)
                {
                    case 1:
                        productController.Create();
                        break;
                    case 2:
                        productController.Edit();
    
                        break;
                    case 3:
                        productController.Delete();
                        break;
                    case 4:
                        productController.GetAll();
                        break;
                    case 5:
                        goto mainMenu;
                    default:
                        Console.WriteLine("Duzgun girin !!!");
                        break;
                  

                }
                break;
                case 4:
                    isFinished= false;
                goto mainMenu;
            default:
                Console.WriteLine("Duzgun secin ");
                goto enterenceChoice;
             
        }
    }
    else
    {
        Console.WriteLine("Duzgun secin");
        goto enterenceChoice;
    }
}