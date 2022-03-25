
     //WAP to display Month Names 
     // Note : Jan , Feb, Mar,Apr,..Dec

using System;

namespace _35Th_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string startDateOfYear = "01/01/2022";
            DateTime dtStartDateOfYear = Convert.ToDateTime(startDateOfYear);
            DateTime dtTemp = dtStartDateOfYear;
            for (int monthNumber = 1; monthNumber <= 12; monthNumber++)
            {
                Console.WriteLine(dtTemp.ToString("MMMM"));
                dtTemp = dtStartDateOfYear.AddMonths(monthNumber);
            }
            Console.ReadLine();
        }
    }
}
