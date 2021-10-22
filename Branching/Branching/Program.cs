using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)

        {
            //Introduction and asking the weight of the package. Indentation in C#, as with any other language is of utmost importance
            //Notice that the first if statement and the last else statement are indented on the same level for a reason
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            short weight = Convert.ToInt16(Console.ReadLine());
            if (weight <= 50)
            {
                //this if statement is the start of all the other if statements because one variable chains to another. If all the if statements
                //from here on out were on the same level the variables from one if statement could not be used on another if statement.
                Console.WriteLine("Please enter the package width:");
                short width = Convert.ToInt16(Console.ReadLine());
                if (width <= 50)
                {
                    Console.WriteLine("Please enter the package height:");
                    short height = Convert.ToInt16(Console.ReadLine());
                    if (height<=50)
                    {
                        //the two integers in this if statement really could have been one, but I wanted to make sure that it was clear for later reference.
                        Console.WriteLine("Please enter the package length:");
                        short length = Convert.ToInt16(Console.ReadLine());
                        int dimensions = width + height;
                        int totaldimensions = dimensions + length;
                        //while all the if statements before this one were <, I wanted to throw a > in because I felt it made things more interesting.
                        if (totaldimensions > 50)
                        {
                            Console.WriteLine("Package too big to be shipped via Package Express.");
                            Console.ReadLine();
                        }
                        else
                        {
                            int price = height * width * length;
                            int workingquote = price * weight;
                            int totalQuote = workingquote / 100;
                            Console.WriteLine("Your estimated total for shipping this package is: $" + totalQuote);
                            Console.ReadLine();

                        }
                        
                    }
                    
                    
                }
                
                
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
            
            
                      