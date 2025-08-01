
using System;
class Test
{
    public static void Main(string[] args)
    {
        //unary Operators
        Console.WriteLine("Unary Operator: ");
        int number2 = 12;
        Console.WriteLine(-number2); //Negative
        Console.WriteLine(number2); //Print Same value of number2 variable

        Console.WriteLine("Increment Decrement: ");
        int number = 10;
        Console.WriteLine(++number);  //11
        Console.WriteLine(number++); //11
        Console.WriteLine(number--); //12
        Console.WriteLine(--number); //10
        Console.WriteLine(number ++); // 10
        Console.WriteLine(number++); //11

    }
}
