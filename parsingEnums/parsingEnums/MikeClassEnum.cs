using System;
namespace parsingEnums
{
    public class MikeClassEnum
    {
       //giving property to class
       public TimeOfTheDay time { get; set; } 
    }
    //Created enums for times of the day
    public enum TimeOfTheDay
    {
        morning,
        afternoon,
        evening,
        night

    }
}
