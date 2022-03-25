/*30) WAP to display the below structure
    11111
    22222
    33333
    44444
    55555
*/
using System;

namespace _30_Display_the_number_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int rownum, colpos;
            rownum = 1;
            while (rownum <= 5)
            {
                colpos = 1;
                while (colpos <= 5)

                {
                    Console.Write(rownum);
                    colpos++;

                }
                Console.WriteLine();
                rownum++;
            }
        }
    }
}
