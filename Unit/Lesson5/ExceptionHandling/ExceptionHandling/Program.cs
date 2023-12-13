void Simple1()
{
    try
    {
        Console.WriteLine("Telefon nomresini daxil edin");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"you entered : {number}");
    }
    catch
    {
        Console.WriteLine("kullanici hatasi");
        //throw;
    }
}



void Simple2()
{
    try
    {
        Console.WriteLine("Telefon nomresini daxil edin");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"you entered : {number}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("kullanici hatasi");
        Console.WriteLine(ex.Message);
        //throw;
    }
}



void Simple3()
{

    // eyni exception-da mesaja esasen ferqli is gormek:
    try
    {
        // data yazma
        throw new InvalidOperationException("test ucun yazdim;");
        throw new InvalidOperationException("test sa yazdim;");
        //data oxuma
    }
    catch (InvalidOperationException ex) when (ex.Message.Contains("sa"))
    {
        // admine sorush
    }
    catch (InvalidOperationException ex) when (ex.Message.Contains("test"))
    {
        // admine sorush
    }
    catch (Exception ex)
    {
        Console.WriteLine("kullanici hatasi");
        Console.WriteLine(ex.Message);
        //throw;
    }
}



void Simple4()
{
    try
    {
        //burada bir request at sorgu gonder,eger netice yoxdursa onda oz exceptionunu cagir
        if (false)
        {
            throw new NotFoundException("netice tapilmadi");
        }
    }
    catch(NotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
    finally {
        Console.WriteLine(":)");
    }
}
//Simple1();
//Simple2();
//Simple3();
Simple4();

class NotFoundException : Exception
{
    public NotFoundException(string message):base(message)
    {
        //loglamani da burda et 
        //send to queie, mail vb
    }
}