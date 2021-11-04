using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the struct Number into Main()
            Number number = new Number();

            //Assigned an amount to number
            number.Amount = 4.56m;

            Console.WriteLine("The amount is " + number.Amount);
            Console.ReadLine();
        }
    }
}
