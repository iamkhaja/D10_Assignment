using System;

namespace _36Th_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime startDayOfweek = DateTime.Today;
            DateTime dtStartDayOfweek = Convert.ToDateTime(startDayOfweek);
            DateTime dtTemp = dtStartDayOfweek;
            for (int dayNumber = 1; dayNumber <= 7; dayNumber++)
            {
                Console.WriteLine(dtTemp.ToString("dddd"));
                dtTemp = dtStartDayOfweek.AddDays(dayNumber);
            }
        }
    }
}
