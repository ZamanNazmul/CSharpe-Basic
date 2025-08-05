using System;

class Program
{
    // Sum of loop series
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int count = 1; count <= num; count++)
        {
            sum = sum + count;

        }
        Console.WriteLine($"Sum = {sum}");
    }
}
