using System;

class Person
{
    public string name;
    public int age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age} \n");
    }

    public void SetValue(string n, int a)
    {
        name = n;
        age = a;
        
    }

}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetValue("Nazmul", 33);
        p1.DisplayInfo();
    
        Person p2 = new Person();
        p2.SetValue("Zaman", 34);
        p2.DisplayInfo();

    }
}
