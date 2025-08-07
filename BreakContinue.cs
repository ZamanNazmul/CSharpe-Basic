using System;

class Test
{
    public static void Main(string[] args)
    {
        // Break and Continue statement.

        // It will print 1 to 99 and skipped 49 , if  i = 100 , it will break; 
     
        for (int i = 1; i <= 100; i++)
        {
            if (i == 50)
            {
                continue;
            }
            if (i == 100)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}
