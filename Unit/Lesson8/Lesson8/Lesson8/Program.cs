#region   Intorduction to Funtions
using MyNuget;
using System.Security.Cryptography;

void Example()
{
    Console.WriteLine("Hello World!");
}
#endregion

// Example();


#region Min Array value

int Min(params int[] arrays)
{
    int findNumber = arrays[0];
    for (int i = 0; i < arrays.Length; i++)
    {
            if (arrays[i] < findNumber)
            {
                findNumber = arrays[i];
            }
         
    }

    return findNumber;
}
#endregion
var result=Min(3,4,5,2,3);
Console.WriteLine(result);




#region MinLength

int Count(int number)
{
    int counter = 0;
    while (number>0)
    {
        number = number / 10;
        counter++;
    }

    return counter;
}

int Sum(int number)
{
    int sum = 0;
    while (number>0)
    {
        sum += number % 10;
        number = number / 10;
        // counter++;
    }

    return sum;
}
#endregion

Console.WriteLine(Count(12324));
Console.WriteLine(Sum(123245));


#region Saitlerin sayilmasi


int SaitCount(string value)
{
    char[] sait = new[] { 'a', 'e', 'i', 'u', 'o' };
    int count = 0;
    for (int i = 0; i < value.Length; i++)
    {
        for (int j = 0; j < sait.Length; j++)
        {
            if (value[i] == sait[j]) count++;
        }
    }

    return count;
}

Console.WriteLine(SaitCount("salam necesen"));
#endregion

MailHelper mailHelper = new MailHelper();

//var result=mailHelper.SendMail(
//    subject:"Welcome",
//    body:"Hello",
//    cc:"sabinaaskarova%^@gmail.com",
//    to:"tetsmail",
//    FromBa
//    )