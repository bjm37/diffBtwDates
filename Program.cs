using System;

namespace diffBtwDates
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date1 = new DateTime();//Define date variables
            DateTime date2 = new DateTime();

            Console.WriteLine("Please enter your first date in the following format: mm/dd/yyyy");//Ask user for the first date
            while (!DateTime.TryParse(Console.ReadLine(), out date1)) //If the datetime input cannot be properly parsed, throw an exception
            {
                Console.WriteLine("Not a valid date format, try again.");
            }


            Console.WriteLine("Please enter your second date (a later date than your first)  in the following format: mm/dd/yyyy");//Ask user for the second date
            while (!DateTime.TryParse(Console.ReadLine(), out date2))
            {
                Console.WriteLine("Not a valid date format, try again.");
            }

            TimeSpan interval = date2 - date1; // new variable to calculate the difference between the two dates
            Console.WriteLine("This is your time interval:");
            Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString()); //print the difference

            //Show the difference in days, hours, and minutes.
            Console.WriteLine("   {0,-35} {1,20}", "", interval.TotalDays + " days difference!");
            Console.WriteLine("   {0,-35} {1,20}", "", interval.TotalHours + " hours difference!");
            Console.WriteLine("   {0,-35} {1,20}", "", interval.TotalMinutes + " minutes difference!");

        }
    }
}
