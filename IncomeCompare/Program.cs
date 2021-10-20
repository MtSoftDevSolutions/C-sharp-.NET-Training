using System;

namespace IncomeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just an intro title for program
            Console.WriteLine("Anonymous Income Comparison Program");

            //Collecting all the pertinent information from Person 1 and 2, we needed hourly rate and amount of time worked per week
            //decided to use double in case someone got paid .50 (i.e. 25.50 instead of just 25)
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate? ");
            string hourlyRate1 = Console.ReadLine();
            double hourRate1 = Convert.ToDouble(hourlyRate1);
            Console.WriteLine("How many hours did you work per week?");
            string time1 = Console.ReadLine();
            double amtoftime1 = Convert.ToDouble(time1);
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate? ");
            string hourlyRate2 = Console.ReadLine();
            double hourRate2 = Convert.ToDouble(hourlyRate2);
            Console.WriteLine("How many hours did you work per week?");
            string time2 = Console.ReadLine();
            double amtoftime2 = Convert.ToDouble(time2);

            // since we have a variable for time per week we just multiply this by 52 since there's 52 weeks in a year
            //once we have variables for amount of time worked in a year, we multiply by their hourly rate
            double year1 = amtoftime1 * 52;
            double year2 = amtoftime2 * 52;
            double annualSalary1 = year1 * hourRate1;
            double annualSalary2 = year2 * hourRate2;

            //This is just filling in the information with the proper variables and casting the boolean into string
            Console.WriteLine("Annual salary of Person 1:\n" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2:\n" + annualSalary2);
            bool salaries = annualSalary1 > annualSalary2;
            string bigshot = Convert.ToString(salaries);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + bigshot);

            //this single line of code exists so the program will be able to be read after all the information is calculated
            Console.ReadLine();
        }
    }
}
