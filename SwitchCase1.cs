using System;

class Test
{
    public static void Main(string[] args)
    {
        // Switch case operation
        int digit;

        Console.Write("Enter the digit: ");
       
        // Use TryParse for safe input handling
        if (!int.TryParse(Console.ReadLine(), out digit))
        {
            Console.WriteLine("Invalid input! Please enter a number.");
            return;
        }

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero"); // ✅ Fixed typo ("Zeno" → "Zero")
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Not a digit");
                break;
        }
    }
}
