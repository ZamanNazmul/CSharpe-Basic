
using System;
class Test
{
    public static void Main(string[] args)
    {
        // Getting the starting number from the user
        Console.Write("Enter the starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        // Getting the ending number from the user
        Console.Write("Enter the ending number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        // Looping from start to end
        for (int i = start; i <= end; i++)
        {
            // Inner loop to print the multiplication table for each i
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"i = {i}, j = {j} => {i * j}");
            }
            Console.WriteLine(); // Adds a blank line between each multiplication table
        }
    }
}
