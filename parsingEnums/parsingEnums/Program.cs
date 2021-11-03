using System;

namespace parsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //try catch for user errors
            try
            {
                //instantiated the MikeClassEnum
                MikeClassEnum variable = new MikeClassEnum();
                //Ask user the time of day
                Console.WriteLine("Is it morning, afternoon, evening, or night time?");
                string userInput = Console.ReadLine();
                variable.time = (TimeOfTheDay)Enum.Parse(typeof(TimeOfTheDay), userInput);
                Console.WriteLine($"Yes, it's {userInput} time.");
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine("Please enter a time of day. (example, morning)");
            }
            Console.ReadLine();
        }
    }
}
