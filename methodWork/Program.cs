using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation of methodWork method
            methodWork worse = new methodWork();
            Console.WriteLine("Input a number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a number");
            int a = Convert.ToInt32(Console.ReadLine());
            worse.Terrible(y, a);
            Console.ReadLine();
            // calling the method in class, specifying by class name
            worse.Terrible(bad: 5, worse: 4);
            Console.ReadLine();

        }
        
    }
}
