using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a constant variable
            const int X = 22;

            //another variable using 'var'
            var Voldemort = "snake";

            //Showing to the console shows that I chained two constructors 
            HouseNames evil = new HouseNames();
            Console.WriteLine(evil.nameOfHouses);
            Console.ReadLine();
        }
    }
}
