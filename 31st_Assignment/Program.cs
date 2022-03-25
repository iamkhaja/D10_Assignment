/*wAP to display the below structure
    1
    22
    333
    4444
    55555*/
using System;

namespace _31_Display_the_number_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x, y;
            x = 1;
            while (x <= 5)
            {
                y = 1;
                while (y <= x)
                {
                    Console.Write(x);
                    y++;

                }
                Console.WriteLine();
                x++;
            }
        }
    }
}
