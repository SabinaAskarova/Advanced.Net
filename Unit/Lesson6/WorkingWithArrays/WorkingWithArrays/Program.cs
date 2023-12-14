
//void Simple1()
//{
//    //1
//    string[] sehirler = new string[5];

//}

//Simple1();

//void Simple2()
//{
//    string[] cars = new string[10];

//    cars[0] = "Ferrari";
//    cars[1] = "BMW";
//    cars[2] = "Mercedes";
//    cars[3] = "Toyota";
//    cars[4] = "Nissan";
//    cars[5] = "Kia";
//    cars[6] = "Toyota Prius";
//    Random random = new Random();
//    int index= random.Next(7);
//    Console.WriteLine(cars[index]);
//}

//Simple2();


//void Cars(){


//}

//List<string> cities = new List<string>() { "Ankara", "İstanbul" };
//cities.Add("Bursa");
//cities.Add("İzmir");
//cities.Add("Antalya");
//cities.Add("Adana");
//cities.Add("Trabzon");
//cities.Add("Samsun");
//cities.Add("Konya");
//cities.Add("Kayseri");
//cities.Add("Kocaeli");
//cities.Add("Diyarbakır");
//cities.Add("Gaziantep");
//cities.Add("Şanlıurfa");
//cities.Add("Mersin");
//cities.Add("Malatya");
//cities.Add("Kahramanmaraş");
//cities.Add("Erzurum");
//cities.Add("Eskişehir");

//// foreach ile 
//int index=0;
//foreach(var item in cities){
//    //index-> item.value
//    System.Console.WriteLine(item.IndexOf(item)+" -> "+item);
//}




List<string> cities = new List<string>() { "Ankara", "İstanbul" };
cities.Add("Bursa");
cities.Add("İzmir");
cities.Add("Antalya");
cities.Add("Adana");
cities.Add("Trabzon");
cities.Add("Samsun");
cities.Add("Konya");
cities.Add("Kayseri");
cities.Add("Kocaeli");
cities.Add("Diyarbakır");
cities.Add("Gaziantep");
cities.Add("Şanlıurfa");
cities.Add("Mersin");
cities.Add("Malatya");
cities.Add("Kahramanmaraş");
cities.Add("Erzurum");
cities.Add("Eskişehir");

// foreach ile 
foreach (var item in cities)
{
    //index-> item.value
    Console.WriteLine(cities.IndexOf(item) + " -> " + item);
}

foreach (var item in cities.Select((value,index)=>(value,index)))
{
    //index-> item.value
    Console.WriteLine(item.index + " -> " + item.value);
}