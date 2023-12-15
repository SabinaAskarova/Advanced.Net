//////string metin = 'A';
////char karakter = 'c';

////string metin = " yeni deger";
////string test = "Salam, necesen? hardasan!";
////for (int i = 0; i < test.Length; i++)
////{
////    if (test[i] == ',' || test[i]==':' || test[i]==';' || test[i]=='/' || test[i] =='*' || test[i] =='-' || test[i] == '+')
////    {
////       test= test.Replace(test[i], ' ');

////    }
////}
//////Console.WriteLine(test);
////test = test.Replace(","," ").
////            Replace(";", " ").
////            Replace("- ", " ").
////            Replace("+", " ").
////            Replace("?", " ").
////            Replace("!", " ");

//string[] testt=test.Split(" ",StringSplitOptions.RemoveEmptyEntries);
//test = string.Join(' ', testt);
//testt.Join()
////Console.WriteLine(test);

////// split

////test=string.Join(' ' ,test.Split('-', '+', '?', '!', ','));

////Console.WriteLine(test);




#region
string metn = "Code Academy rnet103";
int indexOf = metn.ToLower().IndexOf('e');
int lastindexOf = metn.ToLower().LastIndexOf('e');
if (indexOf != -1 || lastindexOf != -1)
{
    if (indexOf != lastindexOf) { Console.WriteLine("birden fazla gecdi"); }
    else Console.WriteLine("bir kez kecdi");
}
#endregion