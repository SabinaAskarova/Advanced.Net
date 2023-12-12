int illikGelir=Convert.ToInt32(Console.ReadLine());
int kreditReytinqi=Convert.ToInt32(Console.ReadLine());
int cariBorc=Convert.ToInt32(Console.ReadLine());

void KreditTesdiqlenmesi(int illikGelir, int kreditReytinqi,int cariBorc)
{
    if (illikGelir > 50000)
    {

        if (kreditReytinqi > 700 && cariBorc == 0)
        {
            Console.WriteLine("Kredit Tesdiqlenir");
        }
        else if (kreditReytinqi < 700 || cariBorc != 0)
        {
            Console.WriteLine("Kredit tesdiqlenmir");
        }

    }
    else
    {
        Console.WriteLine(  "Az maasdir:)");
    }
}

void VergiHesablanmasi(int illikGelir)
{
    double vergi = 0;
    #region switch
    switch (illikGelir)
    {
        case > 0:
            {
                switch(illikGelir)
                {
                    case  < 20000:
                        {
                            vergi = illikGelir * 0.1;
                    Console.WriteLine(vergi);
                    break;
                }
        case < 50000:
                    {
                        vergi =  illikGelir * 0.2;
                        Console.WriteLine(vergi);
                        break;
                    }
                default:
                    {
                        vergi =illikGelir * 0.3;
                        Console.WriteLine(vergi);
                        break;
                    }
                }
                break;
            }
        default:
            {
                Console.WriteLine("sehv gelir daxil edildi");
                break;
            }
         }
    #endregion

    vergi = 0;
    #region if-else 
    if (illikGelir > 0)
    {
        if (illikGelir <= 200000)
        {
            vergi = illikGelir * 0.1;
        }else if (illikGelir<=50000)
        {   
            vergi = illikGelir * 0.2;
        }
        else
        {
            vergi = illikGelir * 0.3;
        }
        Console.WriteLine(vergi);

    }
    else
    {
        Console.WriteLine( "Maas azdir:)");
    }
    #endregion

    vergi = 0;

    #region switch expression
    vergi = illikGelir switch
    {
        < 0 => 0,
        < 20000 => illikGelir * 0.1,
        < 50000 => illikGelir * 0.2,
        _ => illikGelir * 0.3

    };
    #endregion

    Console.WriteLine(vergi);

}

KreditTesdiqlenmesi(illikGelir,kreditReytinqi,cariBorc);
VergiHesablanmasi(illikGelir);