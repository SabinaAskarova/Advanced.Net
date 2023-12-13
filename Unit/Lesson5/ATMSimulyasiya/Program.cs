double budce = 0;
while (true)
{
    Console.WriteLine(@" 1. Pul cixarmaq;
 2. Pul Yatirma;
 3. Budce Sorgulama
 4. Cixis");
    int secim;
	try
	{
        secim = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
	{
		Console.WriteLine ("Emeliyyati duzgun secin:)");
        continue;
	}

    if (secim == 4)
    {
        break;
    }
    else
    {
        int mebleg = 0;
        switch (secim)
        {
            case 1:
                {
                    Console.WriteLine("Cixarmaq istediyiniz meblegi daxil edin: ");
                    try
                    {
                        mebleg = Convert.ToInt32(Console.ReadLine());
                        if (mebleg > budce)
                        {
                            Console.WriteLine("Budcenizde kifayet qeder mebleg yoxdur:)");
                        }
                        else
                            budce -= mebleg;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Meblegi duzgun daxil edin:)");
                    }
                  
                    Console.WriteLine("budceniz: " + budce);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Yatirmaq istediyiniz meblegi daxil edin: ");
                    try
                    {
                        mebleg = Convert.ToInt32(Console.ReadLine());
                        budce += mebleg;
                        Console.WriteLine("budceniz: " + budce);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Meblegi duzgun daxil edin:)");
                    }
                   
                    break;
                }
            case 3:
                {
                    Console.WriteLine("budceniz: " + budce);
                    break;
                }
            default:
                {
                    Console.WriteLine("Bu emeliyyat movcud deyildir:)");
                    break;
                }
        }
        //if(secim==1)
        //{
        //    Console.WriteLine("Cixarmaq istediyiniz meblegi daxil edin: ");
        //    mebleg=Convert.ToInt32(Console.ReadLine());
        //    budce-=mebleg;
        //    Console.WriteLine("budceniz: "+budce);
        //}
        //else if (secim == 2)
        //{
        //    Console.WriteLine("Yatirmaq istediyiniz meblegi daxil edin: ");
        //    mebleg = Convert.ToInt32(Console.ReadLine());
        //    budce += mebleg;
        //    Console.WriteLine("budceniz: " + budce);
        //}
        //if (secim == 3)
        //{
           
        //    Console.WriteLine("budceniz: " + budce);
        //}
    }

}
