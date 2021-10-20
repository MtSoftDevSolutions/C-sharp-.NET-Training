using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //First thing is to get a whole number from user, which is a string
            //data type, then we have to cast it to being a number so the computer 
            //can use it to multiply it by 50.
            Console.WriteLine("Please enter a whole number: ");
            string number = Console.ReadLine();
            long num = Convert.ToInt32(number);
            long Total = num * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + Total);

            //since num was defined in the previous lines, the rest of the assignment
            //becomes easy, just apply different math to the same variable
            long addition = num + 25;
            Console.WriteLine("Your number when added by 25 is: " + addition);


            double division = num / 12.5D;
            Console.WriteLine("Your number divided by 12.5 is: " + division);

            //Again, using the same variable, but we also need another variable to 
            //compare it to so I used int assigned 
            int assigned = 50;
            bool isBigger = num > assigned;
            string big = Convert.ToString(isBigger);
            Console.WriteLine("Your number is bigger than 50: " + big);

            //The % will give the remainder of what the num was divided by 7
            long remains = (num % 7);
            string remain = Convert.ToString(remains);
            Console.WriteLine("What's left over after dividing your number by 7? " + remain);
            Console.ReadLine();
        }
    }
}
