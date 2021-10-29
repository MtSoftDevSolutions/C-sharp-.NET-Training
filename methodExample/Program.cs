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
            Console.WriteLine("Please input a whole number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to input another number? This is optional, you can leave blank. ");
            string next = Console.ReadLine();
            if (string.IsNullOrEmpty(next)) next = "1";
            int b = Convert.ToInt32(next);
           
            RequiredAndOptional.Requirement(a, b);
            

            Console.ReadLine();
        

        }
    }
}
