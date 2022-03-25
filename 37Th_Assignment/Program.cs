
// WAP to display Dates starting 01 Jan 2000 to 31 Dec 2021.
    // Note : The date should be display in dd MMM yyyy format.

using System;

namespace _37Th_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            static int GetMonthDifference(DateTime startDate, DateTime endDate)
            {
                int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
                return Math.Abs(monthsApart);
            }
        }
    }
}
