/*WAP to display the below structure
    55555 
    4444
    333
    22
    1*/

using System;

namespace _33Th_Assignmet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x;
            x = 5;
            while (x >= 1)
            {
                int y = x;
                while (y >= 1)

                {
                    Console.Write(x);
                    y--;

                }
                Console.WriteLine();
                x--;
            }
        }
    }
}
