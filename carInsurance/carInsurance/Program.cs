using System;

namespace carInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //establishing insurance questions and casting them from string to whatever they need to be in
            //order for them to cooperate with the programming that follows.
            Console.WriteLine("What is your age? ");
            string age = Console.ReadLine();
            short qualifyingAge = Convert.ToInt16(age);
            Console.WriteLine("Have you ever had a DUI? True (Yes) False (No) ");
            string naughty = Console.ReadLine();
            bool dui = Convert.ToBoolean(naughty);
            Console.WriteLine("How many speeding tickets do you have? ");
            string speedster = Console.ReadLine();
            short speeding = Convert.ToInt16(speedster);

            //setting parameters for insurability
            bool islegal = (qualifyingAge > 15);
            bool duijail = (dui != true);
            bool speed = (speeding < 3);

            //Using islegal, duijail, and speed booleans we can figure out if they qualify using another boolean
            //first line (28) is saying if: islegal is true, duijail is true, and speed is true from the last block
            //then by the parameters of the car insurance they're qualified
            bool qualifying = (islegal && duijail && speed);
            string qualified = Convert.ToString(qualifying);
            Console.WriteLine("Qualified?\n" + qualified);
            Console.ReadLine();
        }
    }
}
