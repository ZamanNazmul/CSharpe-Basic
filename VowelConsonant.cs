using System;

class Test
{
    public static void Main(string[] args)
    {
        // Switch case operation
        Console.Write("Enter a character: ");
        char input = Convert.ToChar(Console.ReadLine());

        switch (char.ToLower(input))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{input} is a Vowel");
                break;

            default:
                if (char.IsLetter(input))
                {
                    Console.WriteLine($"{input} is a Consonant");
                }
                else
                {
                    Console.WriteLine($"{input} is not a letter");
                }
                break;
        }
    }
}
