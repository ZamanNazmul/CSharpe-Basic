using System;

class Program
{
    // factorial number
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int count = 1; count <= num; count++)
        {
            fact = fact * count;

        }
        Console.WriteLine($"Factorial of this number is : {fact}");
    }
}
