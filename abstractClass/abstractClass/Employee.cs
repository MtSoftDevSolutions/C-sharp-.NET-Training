using System;
namespace abstractClass
{
    public class Employee : Person
    {
        public int Id { get; set; }
        //similar to last assignment other than having to add an override statement
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);

        }

    }
}
