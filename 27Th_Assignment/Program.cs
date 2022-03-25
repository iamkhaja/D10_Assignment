using System;

namespace _27Th_Assignment
{
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                int rownum = 1, colnum = 0, totalnoofrows = 5;
                int spacepos, starpos;
                while (rownum <= totalnoofrows)
                {
                    spacepos = 1;
                    while (spacepos <= (totalnoofrows - rownum))
                    {
                        Console.Write(" ");
                        spacepos++;
                    }
                    starpos = 1;
                    while (starpos <= (2 * rownum) - 1)
                    {
                        Console.Write("*");
                        starpos++;
                    }
                    spacepos = 1;
                    while (spacepos <= (totalnoofrows - rownum))
                    {
                        Console.Write(" ");
                        spacepos++;
                    }
                    Console.WriteLine(" ");
                    rownum++;
                }
                Console.ReadLine();
            }
        }
    }

