using System;

class Program
{
    //Leap Year 
    static void Main()
    {
        int year;
        Console.Write("Enter the year: ");
        year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine($"{year} is a Leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap year");
        }

    }

}
