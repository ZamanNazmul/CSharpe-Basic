using System;
using System.Security.Cryptography;
class First
{
    public static void Main(string[] args)
    {
        string name;
        int age;
        double gpa;
        bool isRegisterd;

        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Entre your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your gpa: ");
        gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Have you already regiserd? : ");
        isRegisterd = Convert.ToBoolean(Console.ReadLine());
        

          
        Console.WriteLine("My name is : " + name);
        Console.WriteLine("I am " + age);
        Console.WriteLine("My gpa is : " + gpa);
        Console.WriteLine("My Status is: " + isRegisterd);
        

    }
}