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
            //created a list of 10 employees with a FirstName, LastName, and Id
            List<Employee> employees = new List<Employee>()
            {
                new Employee {FirstName = "Mike", LastName = "Hall", Id=1},
                new Employee {FirstName = "Flanders", LastName = "Hall", Id=2},
                new Employee {FirstName = "Sofia", LastName = "Hall", Id=3},
                new Employee {FirstName = "Lemmie", LastName = "Hall", Id=4},
                new Employee {FirstName = "Jones", LastName = "Hall", Id=5},
                new Employee {FirstName = "Yolanda", LastName = "Hall", Id=6},
                new Employee {FirstName = "Joe", LastName = "McHall", Id=17},
                new Employee {FirstName = "Queen", LastName = "Hall", Id=18},
                new Employee {FirstName = "Joe", LastName = "Hall", Id=19},
                new Employee {FirstName = "Urkle", LastName = "Hall", Id=10}
            };

            //New List of all employees with the first name Joe using a foreach loop
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }

            foreach (Employee i in newList)
            {
                Console.WriteLine(i.FirstName);
            }
            Console.ReadLine();


            //To do the same thing using a lambda expression
            List<Employee> diffList = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee i in diffList)
            {
                Console.WriteLine(i.FirstName);
            }
            Console.ReadLine();


            //Using a lambda expression, make a list of all employees with an id number greater than 5
            List<Employee> IdList = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee i in IdList)
            {
                Console.WriteLine(i.FirstName);
            }
            Console.ReadLine();
        }
    }
}
