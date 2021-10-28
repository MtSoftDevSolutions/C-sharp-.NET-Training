using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //try exists to put all our desired code in and then validate it basically through catch
            try
            {
                List<int> numbers = new List<int> { 100, 202, 303, 404, 505, 606, 707 };

                Console.WriteLine("Please input a whole number (not zero) to see how it divides 7 different numbers: ");
                int number = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numbers)
                {
                    Console.WriteLine(num / number);
                }
           //Catch with a more exact exception type of FormatException is to catch things like strings and other formats other than integers
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
                return;
            }
            //This error will occur if someone tries to divide by zero
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Don't try to divide by zero");
            }
            //although most errors will have already been caught by the time the compiler gets here, there may be some 
            //other exception that I  hadn't thought of which is why this exception is a catch-all.
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();

            }
            
        }
    }
}
