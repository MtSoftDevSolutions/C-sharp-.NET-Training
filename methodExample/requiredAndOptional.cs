using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace methodExample
{
    public class RequiredAndOptional
    {
        //used params to allow for optional parameter
        static public void Requirement(int userInput, params int[] a1)
        {
            int mul = 1;
            foreach (int num in a1)
            {
                mul *= num;
            }
            Console.WriteLine(mul * userInput);
        }
        
    }

}

