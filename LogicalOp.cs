
using System;
class Testb
{
    public static void Main(string[] args)
    {
        //logical operators

        Console.WriteLine(8 < 9 && 9 < 10 && 10 < 11); //T

        Console.WriteLine(8 > 9 && 9 < 10 && 10 < 11); //F

        Console.WriteLine(8 > 9 || 9 < 10 || 10 < 11); //T

        Console.WriteLine(8 > 9 || 9 > 10 || 10 > 11); //F


        //Logical Not
        Console.WriteLine(!(8 < 9 && 9 < 10 && 10 < 11)); //T

    }
}
