using System;

class Program
{
    static void Main()
    {
        
        int a = 10;
        int b = 20;

        // Ternary operation to get the maximum number
        int max = (a > b) ? a : b;

        Console.WriteLine("The larger number is: " + max);
    }
}
