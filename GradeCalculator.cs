using System;

class Program
{
    static void Main()
    {
      //Grade Calculator
        double marks;
        Console.WriteLine("Enter your Marks: ");
        marks = Convert.ToDouble(Console.ReadLine());

        if (marks >= 0 && marks <= 100)
        {
            if (marks >= 90)
            {
                Console.WriteLine("A");
            }
        
            else if (marks >= 80)
            {
                Console.WriteLine("B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("C");
            }

            else if (marks >= 60)
            {
                Console.WriteLine("D");
            }

            else
            {
                Console.WriteLine("F");
            }

        }
        else
        {
            Console.WriteLine("Entered number is invalid");
        }

        
    }
}
