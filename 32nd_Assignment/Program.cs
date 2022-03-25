/*32) WAP to display the below structure
        1
       22
      333
     4444
    55555
*/
using System;

namespace _32_Display_the_number_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int rownum, colnum;
            rownum = 1;
            while (rownum <= 5)
            {
                colnum = 5;
                while (colnum >= 1)
                {

                    if (colnum > rownum)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(rownum);
                    }
                    colnum--;

                }
                Console.WriteLine();
                rownum++;
            }
        }
    }
}
