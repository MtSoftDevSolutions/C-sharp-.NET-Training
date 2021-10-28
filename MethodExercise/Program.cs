using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting a number from user in order to calculate
            Console.WriteLine("Please input a whole number less than 49 for some calculations.");
            //casting from a string value to an integer in order to calculate
            int userInput = Convert.ToInt32(Console.ReadLine());
            //ints x, y, and z make the numbers each do something different
            int x = threeMethods.addNumber(userInput);
            int y = threeMethods.subNumber(userInput);
            int z = threeMethods.multNumber(userInput);
            //I could leave them in the dark and just have a bunch of numbers up there or I could explain
            //why each number was up there thus improving readability.
            //Also, used concatenation so that the variables would be there after the explanation
            Console.WriteLine("This is your number when added by 7: " + x);
            Console.WriteLine("This is your number when it subtracts from 49: " + y);
            Console.WriteLine("This is your number when multiplied by 51: " + z);
            //this helps show to the user what has happened. 
            Console.ReadLine();
        }
    }
}
