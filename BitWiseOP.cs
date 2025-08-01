
using System;
class Testb
{
    public static void Main(string[] args)
    {
        //Bitwise Operators

        int num1 = 15;
        int num2 = 12;
        int result;


        Console.WriteLine("Bitwise Operations: ");
        result = num1 & num2; //And
        Console.WriteLine($"{num1} & {num2} = {result}");
        // True: If All Are True


        result = num1 | num2; // OR
        Console.WriteLine($"{num1} | {num2} = {result}");
        //True: If Any of Them Are True or If All Ture


        result = num1 ^ num2; // X-OR
        Console.WriteLine($"{num1} ^ {num2} = {result}");
        // True: If Odd are True Else False


        result = 5 >> 1; // Right Shift
        Console.WriteLine($"{5} >> {1} = {result}");
        //Replace right one shift

        result = 14 << 2; // Left Shift
        Console.WriteLine($"{14} << {2} = {result}");
        // Replace left 2 shift
        




    }
}
