using System;

namespace ChapterOnePartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the area calculator.");
            Console.WriteLine("What is the length of the rectangle?");
            string inputLength = Console.ReadLine();
            int length = int.Parse(inputLength);
            Console.WriteLine("Great! The length is " + inputLength + ". What is the width of the rectangle?");
            string inputWidth = Console.ReadLine();
            int width = int.Parse(inputWidth);

            int area = length * width;

            Console.WriteLine("The area of the rectangle is " + area + ".");

        }
    }
}
