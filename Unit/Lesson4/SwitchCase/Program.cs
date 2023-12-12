void Simple1()
{
    string userName = Console.ReadLine();
    if (userName == "admin")
    {
        Console.WriteLine("Admin paneline yonlendiriliyorsunuz");
    }
    else if (userName == "user")
    {
        Console.WriteLine("User paneline yonlendiriliyorsunuz");
    }
    else
    {
        Console.WriteLine("Sen kimsin, Asil sen kimsin");
    }
}

//Simple1();


void Simple2()
{
    string userName = Console.ReadLine();

    switch (userName)
    {
        case "admin":
            {
                Console.WriteLine("Admin paneline yonlendiriliyorsunuz");
                break;
            }
        case "user":
            {
                Console.WriteLine("User paneline yonlendiriliyorsunuz");
                break;
            }
        default:
            {
                Console.WriteLine("Sen kimsin, Asil sen kimsin");
                break;
            }
    }
}

//Simple2();

void Simple3()
{
    int range = int.Parse(Console.ReadLine());

    switch (range)
    {
        case >= 0 and <= 100:
            {
                switch (range)
                {
                    case <= 30:
                        {
                            Console.WriteLine("FF");
                            break;
                        }
                    case <= 50:
                        {
                            Console.WriteLine("DD");
                            break;
                        }
                    case <= 70:
                        {
                            Console.WriteLine("CC");
                            break;
                        }
                    case <= 85:
                        {
                            Console.WriteLine("BB");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("AA");
                            break;
                        }
                }

                break;
            }
        default:
            {
                Console.WriteLine("Gecersiz not");
                break;
            }
    }
}

void Simple4()
{
    string colors=Console.ReadLine();

    switch(colors)
    {
        case == "Siyah":{
    Console.WriteLine("Black");
    break;
}
        case "Siyah":
            {
                Console.WriteLine("Black");
                break;
            }
        case "Kirmizi":
            {
                Console.WriteLine("Red");
                break;
            }
        case == "Yesil":
            {
                Console.WriteLine("green");
                break;
            }
        case  "Sari":
            {
                Console.WriteLine("yelo");
                break;
            }
        case  "Mavi":
            {
                Console.WriteLine("blue");
                break;
            }
        case  "Pembe":
            {
                Console.WriteLine("pink");
                break;
            }
        default:
            {
                Console.WriteLine("");
                break;
            }
    }


}



void Simple5()
{
    string usename = "admin";
    string password = "Salam123";

    switch((usename,password)) {
        case ("admin" , "Salam123"):
            {
                Console.WriteLine("login basarili");
                break;
            }
        default:
            {
                Console.WriteLine("login basarisiz");
                break;
            }
    }
}

