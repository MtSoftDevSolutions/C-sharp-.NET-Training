using System;
namespace abstractClass
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //creating abstract class called SayName
        public abstract void SayName();
        
    }
}
