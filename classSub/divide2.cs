using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSub
{
    class divide2
    {
        //The first method is just dividing by 2. 
        public void divideBy(int a, int b)
        {
            b = 2;
            Console.WriteLine("Your number divided by 2 is: " + (a / b));
        }
        //this method is an example of output parameters
        public void bio(out int number, out string Name)
        {
            number = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Console.WriteLine($"Your name is {Name}. Your favorite number is {number}");
        }
        //this is overloading divideBy because I changed the data type
        public void divideBy(double a, double b)
        {
            b = 3.45;
            Console.WriteLine("Your number divided by my number is: " + (a / b));
        }
  
    }
    //This is making a static class. Static classes can't be instantiated which seems to make things easier.
    public static class Classroom
    {
        public static int resultStorage = 0;
        public static int classSize;
        public static int amtofClasses;
        public static string classType = "Math";
        public static int schoolSum(int classSize, int amtofClasses)
        {
            return classSize * amtofClasses;
        }
        public static void Huge(int result)
        {
            resultStorage = result;
        }
    }
}
