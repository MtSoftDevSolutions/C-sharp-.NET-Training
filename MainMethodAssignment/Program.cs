using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking an int value, outputting an int value
            Console.WriteLine("Input a whole number: ");
            int add = Convert.ToInt32(Console.ReadLine());
            int x = mainMethod.addNumber(add);
            Console.WriteLine(x);
            
            //taking a decimal, outputting an int 
            Console.WriteLine("I demand a decimal. ");
            decimal div = Convert.ToDecimal(Console.ReadLine());
            int y = mainMethod.addNumber(div);
            Console.WriteLine(y);
            
            //taking a string putting out an int
            Console.WriteLine("Your decimal was tasty, can I have another whole number?");
            string hi = Console.ReadLine();
            int z = mainMethod.addNumber(hi);
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
