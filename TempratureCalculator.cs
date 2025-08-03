using System;

class Program
{
    // Switch case with condition
    static void Main()
    {
        Console.WriteLine("Temperature Converter Started:");
        Console.WriteLine("Choose 1. Fahrenheit to Celsius");
        Console.WriteLine("Choose 2. Celsius to Fahrenheit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter Fahrenheit Temperature: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) / 1.8;
                Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
                break;

            case 2:
                Console.Write("Enter Celsius Temperature: ");
                double cels = Convert.ToDouble(Console.ReadLine());
                double fahr = cels * 1.8 + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahr:F2}");
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
