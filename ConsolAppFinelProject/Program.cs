

bool isFinished = true;

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
    bool isTrue=int.TryParse(enterenceChoice, out selectedEnterenceChoice); 

    if(isTrue)
    {
        switch (selectedEnterenceChoice)
        {
            case 1:
                Console.WriteLine("1.Location emeliyyatlari");
                break;
                case 2:
                Console.WriteLine("2.Restoran emeliyyatlari");
                break;
                case 3:
                Console.WriteLine("3.Product  emeliyyatlari");
                break;
                case 4:
                    isFinished= false;  
                break;
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