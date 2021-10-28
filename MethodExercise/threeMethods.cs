using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    public class threeMethods
    {
        //making public so I can share the method to other files. Passing in the userInput paratmeter. Simple math after that
        public static int addNumber(int userInput)
        {
           return (userInput + 7);
           
        }

        public static int subNumber(int userInput)
        {
            return (49 - userInput);
        }

        public static int multNumber(int userInput)
        {
            return (userInput * 51);
        }
    }
}