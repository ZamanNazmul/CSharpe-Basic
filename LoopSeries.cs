using System;

class Program
{
    // Loop series
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int count = 1; count <= num; count++)
            {
            Console.Write($"{count} ");
            }
    }
}
