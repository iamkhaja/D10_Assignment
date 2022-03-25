//WAP to display only 1st days of Months starting from 01 Jan 2001 to as of today.

using System;

namespace D10_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
   
     Console.WriteLine("Today: {0}", DateTime.Now);
               var today = DateTime.Now;
        var StartDate = new DateTime(today.Year, today.Month, 1);
        Console.WriteLine("Start Date of current Month : {0}", StartDate.ToString("yyy/MM/dd"));
        }
    }
}
