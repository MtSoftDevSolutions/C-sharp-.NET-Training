using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample
{
    class Program
    {
        static public void Main()
        {
            //took user input,  casted it to int variable
            Console.WriteLine("Please input a whole number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to input another number? This is optional, you can leave blank. ");
            string next = Console.ReadLine();
            //this part gave me some figuring out to do. Originally if the user left the field blank it made 
            //the program stop. I soon learned about string.IsNullorEmpty which seems to do the trick because now
            //if the user doesn't give us another number, the default number is 1.
            if (string.IsNullOrEmpty(next)) next = "1";
            int b = Convert.ToInt32(next);
           
            RequiredAndOptional.Requirement(a, b);
            

            Console.ReadLine();
        

        }
    }
}
