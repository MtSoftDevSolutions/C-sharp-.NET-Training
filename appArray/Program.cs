using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First thing to do is make an array
            string[] names = { "John", "Jay", "James", "Jordan", "Jason" };
            //Ask for user input
            Console.WriteLine("Please insert a number between 0 and 4");
            //convert user input to a number
            int userIndex = Convert.ToInt32(Console.ReadLine());
            //This will write to the console the array "name" and the value the user inputted "userIndex"
            Console.WriteLine(names[userIndex]);
            Console.ReadLine();
            //Next block of code is basically doing the same thing
            //we just did, but with numbers
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Please put in a number 0 - 4");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myNumbers[userNumber]);
            Console.ReadLine();
            //This is to catch if a user puts in a number that is greater than the 
            //the amount of data we have in the array
            if (userNumber > 4)
                {
                Console.WriteLine("Not an option.");
                Console.ReadLine();
            
                }
            else
            {
                Console.WriteLine(myNumbers[userNumber]);
                Console.ReadLine();
            }
            //Line 43 sets up a new list. Lines 44-46 add to the list
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("Goodbye");
            stringList.Add("She said.");
            Console.WriteLine("Please select a number between 0 and 2 for a random word or phrase.");
            int whatyousay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[whatyousay]);
            Console.ReadLine();
        }
    }
}
