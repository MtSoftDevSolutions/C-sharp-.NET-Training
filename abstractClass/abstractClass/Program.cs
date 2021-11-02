using System;

namespace abstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee() { firstName = "Sample", lastName = "Student" };
            name.SayName();
            Console.ReadLine();
        }
    }
}
