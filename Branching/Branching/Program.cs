using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            short weight = Convert.ToInt16(Console.ReadLine());
            if (weight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                short width = Convert.ToInt16(Console.ReadLine());
                if (width <= 50)
                {
                    Console.WriteLine("Please enter the package height:");
                    short height = Convert.ToInt16(Console.ReadLine());
                    if (height<=50)
                    {
                        Console.WriteLine("Please enter the package length:");
                        short length = Convert.ToInt16(Console.ReadLine());
                        int dimensions = width + height;
                        int totaldimensions = dimensions + length;

                        if (totaldimensions > 50)
                        {
                            Console.WriteLine("Package too big to be shipped via Package Express.");
                            Console.ReadLine();
                        }
                        else
                        {
                            int price = height * width * length;
                            int quote = price / 100;
                            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
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
            
            
                      