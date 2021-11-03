using System;


namespace methodsAndObjects
{
    // Employee : Person is the inheritance statement
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        //polymorphism occurring of interface
        public void Quit()
        {
            Console.WriteLine("Would you like to quit?");
        }
        public static bool operator ==(Employee Mike, Employee Jane)
        {
            return Mike.Id == Jane.Id;
            
        }

        public static bool operator !=(Employee Mike, Employee Jane)
        {
            return Mike.Id != Jane.Id;
        }
    }
}
