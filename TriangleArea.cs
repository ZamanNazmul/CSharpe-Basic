using System;
class Test
{
    public static void Main(string[] args)
    {
        double baseLength, height, trianglearea;

        Console.WriteLine("Triangle Area Calculator: ");

        Console.WriteLine("Base: ");
        baseLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Height: ");
        height = Convert.ToDouble(Console.ReadLine());

        trianglearea = 0.5 * baseLength * height;
        Console.WriteLine($"Triangle Area: {trianglearea.ToString("F2")}");

    }
}
