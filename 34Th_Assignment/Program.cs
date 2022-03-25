/*
 * WAP to display the below structure
    55555
    44444
    33333
    22222
    11111*/

using System;

namespace _34Th_Assignment
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
                int y = 5;
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
