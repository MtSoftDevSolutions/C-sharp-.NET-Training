using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {   //I introduce the introductory phrase as a string with \n making two lines two my knowledge the language requires
            //both writeline to have something to write and readline so that the user can actually see the input
            string Intro = "The Tech Academy\nStudent Daily Report";

            Console.WriteLine(Intro);

            Console.ReadLine();

            //Console.WriteLine ("What is your name?") will collect user input for their name, I then converted it as a string so that I could 
            //use it later in the next Console.WriteLine using user input
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("Username is: " + studentName);
            Console.ReadLine();

            //Same idea as lines 18-21 just different question
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are currently on: " + courseName);
            Console.ReadLine();

            //This was my first time casting (changing one data type to another) Console.WriteLine makes user input string data
            //while I could have left it as a string data, I wanted to be more precise and learn, I also knew that because declaring 
            //data type allocates memory and there aren't that many numbers possible for answering the question I made the data type
            //short as short is one of the smaller number data types, uses less memory, and can answer the question successfully.
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            short pageNum = Convert.ToInt16(pageNumber);
            Console.WriteLine("Your Current Page is: " + pageNum);
            Console.ReadLine();

            //Below is the boolean data type, which the way I did it was because I have to learn how to do it correctly still
            //I wish I could have used either checkmarks or radio buttons instead of insisting that the user enter True or False
            //In the real world I know there will be many answers possible and thus would cause a bug if this wasn't just for practice.
            Console.WriteLine("Do you need help with anything?\nPlease answer True for Yes or False for No");
            string yesNo = Console.ReadLine();
            bool help = Convert.ToBoolean(yesNo);
            Console.WriteLine(help);
            Console.ReadLine();

            //This one was interesting because I wasn't sure how this would work if the user was 'wordy', but it seemed to work fine
            //although on second thought I may have just wanted to leave it writeline to have user input, but not readline because it 
            //doesn't look aesthetically pleasing. 
            Console.WriteLine("Were there any positive experiences you\'d like to share?\nPlease give specifics.");
            string review = Console.ReadLine();
            Console.WriteLine(review);
            Console.ReadLine();

            //This one was fun as I got to concatenate and cast
            Console.WriteLine("How many hours did you study today?");
            string manyHours = Console.ReadLine();
            short hours = Convert.ToInt16(manyHours);
            Console.WriteLine("Congratulations, you studied: " + hours + " hours today.");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
