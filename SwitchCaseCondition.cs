using System;

class Program
{
    // Switch case with condition
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number: ");

        switch (number)
        {
            case int num when num < 1 || num > 10: // we can't call same variable here we must change previous variable name
                Console.WriteLine($"Number is out of Range"); // if we use condition we must use when word
                break;
            case int num when num % 2 == 0:
                Console.WriteLine($"Even Number: ");
                break;
            case int num when num % 2 != 0:
                Console.WriteLine($"Odd Number");
                break;
            default:
                Console.WriteLine($"Default case");
                break;
        }



    }
}
