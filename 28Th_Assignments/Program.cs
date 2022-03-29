using System;

namespace _28Th_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int temp = 1;
            int  rownum= 5;
            while (rownum >=1)
            {
                int colnum = 1;
                while (colnum < temp)
                {
                    Console.Write(" ");
                        colnum++;
                }
                    {
                    int starcount = 1;
                    while (starcount <= 2 * rownum - 1)
                    {
                        starcount++;
                        Console.Write("*");

                    }
                    temp++;
                    rownum--;
                    Console.WriteLine();
                }
            }
        }
    }
}
