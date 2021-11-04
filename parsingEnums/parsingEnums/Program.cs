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
                //Ask user the day like Monday, Tuesday, Wednesday, etc.
                Console.WriteLine("What day is it?");
                string userInput = Console.ReadLine();
                variable.day = (WhatDay)Enum.Parse(typeof(WhatDay), userInput);
                Console.WriteLine($"Yes, it's {userInput}.");
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week (like Monday, Tuesday, etc.)");
            }
            Console.ReadLine();
        }
    }
}
