//Fahrenheit to Celsius
using System;
using System.Drawing;
class Test
{
    public static void Main(string[] args)
    {
        double fahrenheit, celsius;
        Console.Write("Enter the fahrenhier: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        celsius = (fahrenheit - 32) / 1.8;
        Console.WriteLine($"Celsius = {celsius.ToString("F3")}");

    }
}
