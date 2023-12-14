using System.Linq;

string[] cities =
{
"New York",
"Paris",
"London",
"Sydney",
"Cairo",
"London",
"Moscow",
"Toronto",
"Mumbai",
"Rome"
};
//if(Array.IndexOf(cities,"London")!=Array.LastIndexOf(cities,"London")) Console.WriteLine("iki defe tekrarlanib");
//for (int i = 0; i < cities.Length; i++)
//{
//    for (int j = 0; j < cities.Length; j++)
//    {
//        if (cities[i] == cities[j] && i!=j)
//        {
//            Console.WriteLine(cities[i]+" iki defe tekrarlanib");
//        }
//    }
//}

string olke = "Azerbaycan".ToLower();
//Console.WriteLine(olke.Length);
for (int i = 0; i < olke.Length; i++)
{
    //int counter = 1;
    //for (int j = 0; j < olke.Length; j++)
    //{
    //    if (olke[i] == olke[j] && i != j) { counter++; }
    //}
    //Console.WriteLine(olke[i]+ " sayi: "+counter);

    Console.WriteLine(olke[i] + " sayi: "+olke.Where(c => c == olke[i]).Count()); ;
}

var olkee = olke.Select((value) => (value));
var result = olke.Where(c => c ==  (olke.Select((value) => (value))).Count());
Console.WriteLine();
