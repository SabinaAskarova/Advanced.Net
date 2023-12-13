string havadurumu = Console.ReadLine();
int kulekSureti = int.Parse(Console.ReadLine());
int cariIstilik = int.Parse(Console.ReadLine());

if (kulekSureti < 25)
{
    if (cariIstilik < 30 && cariIstilik > 0)
    {
        if(havadurumu=="yagisli") Console.WriteLine("cetir goturun ve biraz isti geyinin...");
        if(havadurumu=="gunesli") Console.WriteLine("gezmeye ve ya mc donaldsa gede bilersen...");
        if(havadurumu=="qarli") Console.WriteLine("isti geyinib qar topu oynamaga gede bilersen...");
    }
    else
    {
        if (havadurumu == "qarli") Console.WriteLine("isti geyinib qar topu oynamaga gede bilersen...");
    }
}
if (kulekSureti > 50)
{
    Console.WriteLine(  "evde otur");
}
