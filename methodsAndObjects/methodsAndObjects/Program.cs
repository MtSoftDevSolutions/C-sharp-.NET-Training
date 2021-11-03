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
            //instantiating the Interface
            IQuittable joe = new Employee();
            joe.Quit();
            //name.Quit();
            Employee employee = new Employee() { Id = 1000 };
            Employee employee1 = new Employee() { Id = 2000 };
            Console.WriteLine(employee == employee1);
            Console.ReadLine();
            
        }
    }
}
