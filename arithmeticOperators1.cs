using System;
class Test
{
    public static void Main(string[] args)
    {
        int a, b, c, sum;
        double average;

        Console.Write("NUmber 1: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("NUmber 2: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("NUmber 3: ");
        c = Convert.ToInt32(Console.ReadLine());

        sum = a + b + c;
        Console.WriteLine("Sum is: " + sum);

        average = sum / 3;
        Console.WriteLine("Agerage is : " + average.ToString("F3"));

    }
}
