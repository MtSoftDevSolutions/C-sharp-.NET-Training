using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee() { FirstName = "Sample", LastName = "Student"};
            name.SayName();
            IQuittable joe = new Employee();
            joe.Quit();
            name.Quit();
            Console.ReadLine();
            
        }
    }
}
