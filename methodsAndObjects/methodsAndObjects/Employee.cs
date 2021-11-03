using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndObjects
{
    // Employee : Person is the inheritance statement
    public class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }

        //polymorphism occurring of interface
        public void Quit()
        {
            Console.WriteLine("Would you like to quit?");
        }

        //checking to see if the two ids are equal 
        public static bool operator ==(Employee <T> obj1, Employee <T> obj2)
        {
            bool answer = (obj1.Id == obj2.Id);
            return answer;
            
        }
        //have to include the overload of "!=" to use the method above
        public static bool operator !=(Employee<T> obj1, Employee<T> obj2)
        {
            bool answer = (obj1.Id != obj2.Id);
            return answer;
        }

        //List things = public List<T> employeeList { get; set; }
    }
}
