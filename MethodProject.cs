using System;

class Program
{

      public static void Sub(int number1, int number2)
    {
        int result = number1 - number2;
         Console.WriteLine($"{number1} - {number2} = {result}");
    }

    public static void Add(int number1, int number2)
    {
        int result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
    }

    public static void Greeting()
    {
        Console.WriteLine("Hello");
    }

    public static void Coder()
    {
        Console.WriteLine("My Name is: Nazmul Zaman");
        // Add();
    }
    public static void Main(string[] args)
    {
        Greeting();
        Coder();
        
        int number1, number2;
    
        //Additino
        number1 = 10;
        number2 = 20;
        Add(number1, number2);

        number1 = 30;
        number2 = 40;
        Add(number1, number2);
      
        number1 = 50;
        number2 = 60;
        Add(number1, number2);
       

       //Subtraction
        number1 = 60;
        number2 = 20;
        Sub(number1, number2);
       
        number1 = 40;
        number2 = 30;
        Sub(number1, number2);

        number1 = 50;
        number2 = 10;
        Sub(number1, number2);

        Console.Read();
    }
}
