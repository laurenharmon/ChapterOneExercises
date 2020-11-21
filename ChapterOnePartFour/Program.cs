using System;

namespace ChapterOnePartFour
{
    class Program
    {
        static void Main(string[] args)
        {

            string adventureSentence = "Alice was beginning to get very tired " +
                "of sitting by her sister on the bank, and of having nothing to do: " +
                "once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'";

 
            Console.WriteLine("Which word from the first sentence of Alice in Wonderland would you like to search for? ");
            string input = Console.ReadLine();
//CHECK FOR WORD IN SENTENCE AND PRINT THE INDEX + LENGTH
            if (adventureSentence.ToLower().Contains(input.ToLower())) {
                Console.WriteLine("true");
                Console.WriteLine("That word appears from index: " + adventureSentence.IndexOf(input) + " and is " + input.Length + " characters long. Without the word, the sentence looks like this: ");
//SPLIT SENTENCE AND PRINT WITHOUT SEARCHED WORD
                string[] withoutInput = adventureSentence.Split(input);
                for (int i = 0; i < withoutInput.Length; i++)
                {
                    Console.WriteLine(withoutInput[i]);
                }

            } else
            {
                Console.WriteLine("false");
            }
        }
    }
}
