void Simple1()
{
    /*
     Personel p=new90;
    p.adi="Murat"
    _context.Personeller.Add(p);
    _context.SaveChanges();---deyisenen setir sayisini return edir
     */

    bool result = default;
    if (!result)
    {
        Console.WriteLine("olmadi");
    }
    else
    {
        Console.WriteLine("kayit eklendi;");
    }
    string retVal = result switch
    {
        true => "kayit eklendi",
        _ => "hatali ishlem"
    };

    string message = result ? "kayit eklendi" : "hatali ishlem";

    string message2 ="Kayit " +(result ? " eklendi" : " eklenemedi");

    Console.WriteLine(result ? "kayit eklendi" : "hatali ishlem");

    // 
}                                        

Simple1();