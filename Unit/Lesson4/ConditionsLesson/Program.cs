// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void Simple1()
{
    string username = "admin";
    if (username == "admin")
    {
        Console.WriteLine("Hello admin!");
    }
    else {
        Console.WriteLine("You have logged in incorrectly");
    }
}

//Simple1();

void Simple2()
{
    int note = int.Parse(Console.ReadLine());
    if(note>0 ){
        if (note < 100) {
            Console.WriteLine("Your note is: " + note);
        }
        else
        {
            Console.WriteLine("your note is not right");

        }
    }
    else
    {
        Console.WriteLine("your note is not right");
    }
}

//Simple2();
//Simple2();

void Simple3()
{
    int note = int.Parse(Console.ReadLine());
    if (note > 0 && note < 100)
    {
        Console.WriteLine("Your note is: " + note);
    }
    else
    {
        Console.WriteLine("your note is not right");
    }
}

//Simple3();


void Simple4()
{
    int range = int.Parse(Console.ReadLine());
    if (range >= 0 && range <= 100)
    {
        if (range >= 0 && range <= 30)
        {
            Console.WriteLine("FF");
        }
        else if (range > 30 && range <= 50)
        {
            Console.WriteLine("DD");
        }
        else if (range > 50 && range <= 70)
        {
            Console.WriteLine("CC");
        }
        else if (range > 70 && range <= 84)
        {
            Console.WriteLine("BB");
        }
        else if (range > 84 && range <= 100)
        {
            Console.WriteLine("AA");
        }
    }
    else
    {
        Console.WriteLine("gecersiz not");
    }
}

Simple4();  




