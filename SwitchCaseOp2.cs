using System;

class Test
{
    public static void Main(string[] args)
    {
        // Switch case operation
        Console.Write("Enter a day name: ");
        string day = Console.ReadLine();

        switch (day.ToLower())
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
            case "friday":
                Console.WriteLine("Weekday");
                break;
            case "saturday":
            case "sunday":
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("not da valid day");
                break;
        }
    }
}
