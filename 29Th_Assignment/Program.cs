//WAP to display the below structure
        //1
      // 234
     // 56789
   //101112131417

using System;

namespace _29Th_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int rownum, colnum;
            int displaynum = 1;
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
                        Console.Write(displaynum);
                        displaynum++;
                    }
                    colnum--;

                }
                Console.WriteLine();
                rownum++;

            }
        }
    }
}
