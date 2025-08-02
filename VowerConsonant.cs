using System;

class Program
{
    // Check if a letter is a vowel or consonant
    static void Main()
    {
        Console.Write("Enter a single letter: ");
        string input = Console.ReadLine();

        if (input.Length == 1 && char.IsLetter(input[0]))
        {
            char letter = char.ToLower(input[0]);

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine($"{letter} is a Vowel letter");
            }
            else
            {
                Console.WriteLine($"{letter} is a Consonant letter");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a single alphabet letter.");
        }
    }
}
``
