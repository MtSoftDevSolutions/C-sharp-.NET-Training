using System;
using System.Collections.Generic;
using System.Linq;

namespace conzoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] mlbTeams = { "Royals", "Twins", "Dodgers", "Braves", "Giants" };
            //Console.WriteLine("Make up a chant/cheer for an MLB team.");
            //string userInput = Console.ReadLine();
            //for (int i = 0; i <= mlbTeams.Length; i++)
            //{
            //    mlbTeams[i] = mlbTeams[i] + ' ' + userInput;
            //    Console.WriteLine(mlbTeams[i]);

            //}
            //Console.ReadLine();


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
            //List<string> Inventors = new List<string> { "Albert Einstein", "Thomas Edison", "Wright Brothers", "Nick Tesla" };
            //Console.WriteLine("Please choose either Albert Einstein, Thomas Edison, Wright Brothers, or Nick Tesla as input.");
            //string userInput = Console.ReadLine();
            ////I've decided to keep my mistakes so that I will remember why they were mistakes
            ////foreach will loop through each of the indexes, so I was having trouble with something repeating
            ////the culprit was the foreach statement.
            ////foreach(string inventor in Inventors)
            ////{
            //    if (Inventors.Contains (userInput))
            //    {
            //        Console.WriteLine(Inventors.IndexOf(userInput));

            //}
            //    else 
            //    {
            //        Console.WriteLine("While this person may be important, they were not represented on this list.");
            //    }


            ////}

            //Console.ReadLine();
            //Part 5 using linq
            //List<string> Names = new List<string> { "Albert", "Joe", "Miles", "Joe", "Michael" };
            //Console.WriteLine("Are you looking for Albert, Joe, Miles, Joe, or Michael? Please input First Name: ");
            //string firstName = Console.ReadLine();

            //var result = Names.Select((c, i) => new { character = c, index = i }).Where(list => list.character == firstName).ToList();
            //foreach (string name in Names)
            //{

            //    if (Names.Contains(firstName))
            //    {
            //        Console.WriteLine(Names.IndexOf(firstName));

            //    }

            //    else
            //    {
            //        Console.WriteLine("Does not match the list of names.");
            //    }
            //    int x = 0;
            //    while ((x = Names.IndexOf(firstName, x)) != -1)
            //    {
            //        Console.WriteLine("index " + x);
            //        x++;
            //    }
            //    break;
            //}
            //    Console.ReadLine();
            
            //**********************Part 6****************************************************************
            List<string> mascots = new List<string> { "Lions", "Lions", "Tigers", "Bears", "Packers" };
            //Created another list to help sort duplicates
            List<string> moreMascots = new List<string> { };
            //iteration
            foreach (string party in mascots)
            {
                //iteration in the other list
                foreach(string town in moreMascots)
                {
                    //if there is a duplicate
                    if (party == town)
                    {
                        Console.WriteLine(party + " occurred more than once.");
                    }


                }
                //if no duplicate present
                if (moreMascots.Contains(party)==false)
                {
                    Console.WriteLine(party + " has not happened before.");
                }
                moreMascots.Add(party);

            }
            Console.ReadLine();



        }
    }
}
