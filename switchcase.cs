using System;

class Test
{
    public static void Main(string[] args)
    {
        // Switch case operation
        int number1, number2;
        char operation;

        Console.WriteLine("Enter an operation(+,-,*,/)");
        operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                break;

            case '-':
                Console.WriteLine($"{number1} + {number2} = {number1 - number2}");
                break;

            case '*':
                Console.WriteLine($"{number1} + {number2} = {number1 * number2}");
                break;

            case '/':
                if (number2 != 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {number1 / number2}");
                }
                else
                {
                     Console.WriteLine("Can Not Divided By Zero");
                }
               
                break;
            default:
                Console.WriteLine("You've Entered Invalid operation ");
                break;
        }




