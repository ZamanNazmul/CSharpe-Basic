using System;

class Program
{
    // Check if a letter is capital or small
    static void Main()
    {
        char letter;
        Console.Write("Enter the letter: ");
        letter = Convert.ToChar(Console.ReadLine());

        if (letter >= 'A' && letter <= 'Z')
        {
            Console.WriteLine($"{letter} is a capital letter");
        }
        else
        {
            Console.WriteLine($"{letter} is a small letter");
        }
    }
}
