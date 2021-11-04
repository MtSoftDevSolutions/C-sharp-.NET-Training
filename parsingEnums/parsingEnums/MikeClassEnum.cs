using System;
namespace parsingEnums
{
    public class MikeClassEnum
    {
       //giving property to class
       public WhatDay day { get; set; } 
    }
    //Created enums for times of the day
    public enum WhatDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
