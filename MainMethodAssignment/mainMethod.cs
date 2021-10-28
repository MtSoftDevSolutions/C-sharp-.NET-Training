using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class mainMethod
    {
        //this one was from into to int
        public static int addNumber (int add)
        {
            return (add + 7);
        }

        //this one goes from decimal to int
        public static int addNumber(decimal div)
        {
            int result = Convert.ToInt32(div);
            return (50 / result);


        }
        //this one took a string and converted it to an int
        public static int addNumber(string hi)
        {
            int stringy = Convert.ToInt32(hi);

            return (stringy * 7);
        }

    }
}
