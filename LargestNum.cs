using System;

class Program
{
  //Find largest number?
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("The largest number is: " + num2);
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }
}
