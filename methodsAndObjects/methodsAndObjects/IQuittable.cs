using System;
namespace methodsAndObjects
{
    public interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Something else");
        }
    }
}
