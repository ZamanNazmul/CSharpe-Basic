
using System;

class Test
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a number from 1 to 10 or write the word Quit to exit the app");

            string input = Console.ReadLine() ?? "";
            input = input.ToLower().Trim();

            if (input == "quit")
            {
                Console.WriteLine("Thanks for using our app");
                break;
            }

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine($"Enter a valid input.Please give a number");
                continue;
            }

             if (! (number >= 1 && number <= 10))
            {
                Console.WriteLine($"The given number is not in range, Enter 1 to 10");
                continue;
            }


                int square = number * number;
                Console.WriteLine($"Square of {number} = {square}");
        }
    }
}
