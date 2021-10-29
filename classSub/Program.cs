using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a class in divide2 that divides a number input from user by 2.
            divide2 now = new divide2();
            Console.WriteLine("Please give me a whole number you\'d like divided by 2: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 2;
            now.divideBy(a, b);
            Console.ReadLine();
            //This is what is needed in the main program.cs in order to have an example of output parameters
            Console.WriteLine("Please enter your favorite number: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            string message = isValid ? $"Your favorite number is {number}." : "Please enter a valid number";
            Console.WriteLine("What is your name? ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Your name is {Name}. " + message);
            Console.ReadLine();
            //This overloads divide2 because I changed the data type from int to double
            divide2 when = new divide2();
            Console.WriteLine("Please give me any number: ");
            double zed = Double.Parse(Console.ReadLine());
            double bed = 3.45;
            when.divideBy(zed, bed);
            Console.ReadLine();
            //This is using a static class
            Console.WriteLine("How many people do you have in your class? ");
            int classSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many classes do you have? ");
            int amtofClasses= Convert.ToInt32(Console.ReadLine());
            //This is still using the same static class plus what I learned from output parameters
            var result = Classroom.schoolSum(classSize, amtofClasses);
            Console.WriteLine($"You have {classSize} students in your class and {amtofClasses} classes.\n " +
                $"That totals to {result} students.\n Geesh it\'s time for a vacation!");
            Console.ReadLine();

        }
    }
}
