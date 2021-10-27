using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //concatenating 3 strings
            Console.WriteLine("Jesse is " + "a great " + "guy!");
            Console.ReadLine();
            //making a variable 'name' so that I can use it to make it all caps in the 
            //next line
            string name = "Michael";
            string upper = name.ToUpper();
            Console.WriteLine(upper);
            Console.ReadLine();
            //StringBuilder is a great tool. Basic run down here... through creating a new
            //stringbuilder called sb and using .append I  have basically formed a paragraph.
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Michael.\n");
            sb.Append("I love C#.\n");
            sb.Append("I hope to become a C# developer one day.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
