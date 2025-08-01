//Fahrenheit to Celsius
using System;
class Test
{
    public static void Main(string[] args)
    {
        //a += b or a = a  + b both are same
        Console.WriteLine("Assignment Operator Example: ");

        int number = 20;

        number += 5;
        Console.WriteLine($"{number}");


        number -= 5;
        Console.WriteLine($"{number}");

        number *= 5;
        Console.WriteLine($"{number}");

        number /= 5;
        Console.WriteLine($"{number}");

        number %= 5;
        Console.WriteLine($"{number}");


    }
}
