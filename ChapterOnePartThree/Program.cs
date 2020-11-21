using System;

namespace ChapterOnePartThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that asks a user for 
             * the number of miles they have driven and the amount of gas 
             * they’ve consumed (in gallons), and print their miles-per-gallon. */

            Console.WriteLine("Welcome to the miles per gallon calculator.");
            Console.WriteLine("How many miles have you driven?");
            string milesGiven = Console.ReadLine();
            int miles = int.Parse(milesGiven);

            Console.WriteLine("Thanks! How many gallons of gas did you use?");
            string gallonsGiven = Console.ReadLine();
            int gallons = int.Parse(gallonsGiven);

            int milesPerGallon = miles / gallons;

            Console.WriteLine("Your vehicle travels " + milesPerGallon + "miles per gallon.");

        }
    }
}
