using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int count = 0; count <= number; count++)
        {
            Console.WriteLine($"{count}");
        }
    }
}
