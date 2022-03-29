using System;

namespace _21st_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i, j;
            for (i = 65; i <= 69; i++)
            {
                j = i + 32;
                Console.Write("" +Convert.ToChar(i) + Convert.ToChar(j) +  " ");
            }

        }
    }
}
