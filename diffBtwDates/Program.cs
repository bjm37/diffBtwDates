using System;

namespace diffBtwDates
{
    class Program
    {
        static void Main(string[] args)
        /*Write a C# console application to calculate the duration between two dates in Years, Months and Days. 
         The user should enter two dates as input, then the program will show the result of the difference in time between these two dates. 
         Show the difference in days, hours, and minutes*/
        {
            // Define two dates.
            DateTime date1 = new DateTime(1990, 11, 6, 9, 30, 45);
            DateTime date2 = new DateTime(1993, 8, 31, 6, 0, 8);
            
            // Calculate the interval between the two dates in Years, months, and days
            TimeSpan interval = date2 - date1;
            Console.WriteLine(interval.ToString());
        }
    }
}
