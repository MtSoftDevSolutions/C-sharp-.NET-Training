using System;
namespace methodsAndObjects
{
    public interface IQuittable
    {
        //Quit() method of interface, will be polymorphed in employee.cs so the writeline will change
        public void Quit()
        {
            Console.WriteLine("Something else");
        }
    }
}
