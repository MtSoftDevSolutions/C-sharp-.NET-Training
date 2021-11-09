using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a DateTime named CurrentTime that equates to the current date and time
            DateTime CurrentTime = DateTime.Now;
            //below line will print current date and time to the console
            Console.WriteLine("The current datea nd time is " + CurrentTime);

            //Getting a number from the user and saving it as an integer
            Console.WriteLine("Please give me a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Prints to the console the time it will be in X hours, X being the number the user entered
            Console.WriteLine("The current time plus the amount of hours = " + CurrentTime.AddHours(userNum));

            Console.ReadLine();
        }
    }
}
