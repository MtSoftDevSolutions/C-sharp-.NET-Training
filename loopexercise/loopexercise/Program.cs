using System;

namespace loopexercise
{
    class Program
    {
        static void Main(string[] args)
        {//Next line will be the first thing user sees in the console app. 
            Console.WriteLine("Enter a number 1 - 5 and you'll have a new favorite MLB team. Is it fate, or is it part of an assignment.");
            //declaring data type integer to variable named team
            int team = Convert.ToInt32(Console.ReadLine());
            //rightTeam will be the boolean variable checked against in the following while loop
            bool rightTeam = team == 1;
           //while rightTeam is false do this 
            while (!rightTeam)
            switch (team)
                {
                    case 5:
                        Console.WriteLine("Your new favorite team is the Reds. Try again.");
                        Console.WriteLine("Guess again to learn my favorite team.");
                        //the next line is extremely important to prevent an infinite while loop
                        team = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Your new favorite team is the Blue Jays. Try again.");
                        Console.WriteLine("Guess again to learn my favorite team.");
                        team = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Your new favorite team is the Cubs. Try again.");
                        Console.WriteLine("Guess again to learn my favorite team.");
                        team = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Your new favorite team is the Braves. Try again.");
                        Console.WriteLine("Guess again to learn my favorite team.");
                        team = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You are correct. You're now a fan of the Dodgers, me too!");
                        rightTeam = true;
                        break;
                    default:
                        Console.WriteLine("You entered a number other than 1 - 5. Try again.");
                        Console.WriteLine("Guess again.");
                        break;

                }
            Console.ReadLine();



            Console.WriteLine("What is the age when we enter adulthood?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isLegal = number == 18;
            //From the previous while loop, it is hard to see what would have happened if it was left without being a do while loop
            //but if it's just a while loop and the first number was correct then there would be no writeline to be read, so
            //putting do before the loop allows for everything to be run correctly resulting in that if the first answer was right
            //the text pertaining to that case would still be present. 
            do
            {
                switch (number)
                {
                    //case vs default... cases pertain to specific instances.. For example, case 17 happens if someone chooses to input
                    //the number 17. Default is for all those numbers that are not right, but also don't have a specific case. It's a
                    //catch-all. 
                    case 17:
                        Console.WriteLine("Add a year to it and you'd be right.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("Maybe you got a car for your birthday this year, but you're still a minor.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Uh, no. Not quite right.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("While this is the first year of being a teenager, thinking you know better, you're still not an adult.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 18:
                        Console.WriteLine("You are correct.");
                        isLegal = true;
                        break;
                    default:
                        Console.WriteLine("Not quite, guess again.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isLegal);
            
            //both this console.readline and the one before it in line 49 are important as without them nothing would be
            //seen on the screen. 
            Console.ReadLine();

          
        }
    }
}
