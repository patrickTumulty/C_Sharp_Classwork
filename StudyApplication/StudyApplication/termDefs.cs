using System;
using System.Collections.Generic;

namespace StudyApplication
{
    public class termDefs
    {
        List<string> Terms = new List<string>();
        List<string> Definitions = new List<string>();
        bool loop = false;
        int i = 0; // i keeps track of the number of terms and definitions that are being entered 

        public termDefs()
        {
            while (loop == false)
            {
                Console.WriteLine("Enter Term: ");
                Terms.Add(Console.ReadLine().ToLower()); // converts all input strings to lower case. 
                Console.WriteLine("Enter Term Definition: ");
                Definitions.Add(Console.ReadLine().ToLower());
                Console.WriteLine("Type a to add another term");
                Console.WriteLine("Type b to continue");
                i++;
                if (Console.ReadLine() == "b")
                {
                    break;
                }
            }
            Console.WriteLine("Type b to start quiz");
            Console.WriteLine("Type a to see terms");
            string input = Console.ReadLine();
            if (input == "b")
            {
                quizTerms();
            }
            if (input == "a")
            {
                showTerms();
                Console.WriteLine("Type b to start quiz");
                Console.WriteLine("Type any button to quit");
                string input2 = Console.ReadLine();
                if (input2 == "b")
                {
                    quizTerms();
                }

            }
        }
        public void showTerms()
        {
            // this function is so the user can check their input

            for (int num = 0; num < i; num++)
            {
                Console.WriteLine(Terms[num]);
                Console.WriteLine(Definitions[num]);
            }
        }
        public void quizTerms()
        {
            // local variables used only for this method 

            Random rnd = new Random();
            int score = 0;
            int loopNum = 0;
            bool loop = false;
            string end = "end";

            Console.WriteLine("Beginning Quiz:");
            Console.Clear();
            Console.WriteLine("Write the term that matches the definition: ");
            Console.WriteLine("At Anytime you can type 'end' to stop the quiz.");
            Console.ReadKey();
            while (loop == false)
            {
                int locTerm = rnd.Next(0, (i - 1)); // loc term stands for locate term
                Console.ResetColor();
                Console.WriteLine(Definitions[locTerm]);
                string response = Console.ReadLine().ToLower();
                if (response == Terms[locTerm])
                {
                    score++;
                    loopNum++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Correct");
                    Console.ResetColor();
                }
                else
                {
                    loopNum++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect");
                    Console.WriteLine(Terms[locTerm]);
                    Console.ResetColor();
                }
                if (response == end)
                {
                    Console.WriteLine("You got " + score + " out of " + loopNum + " questions correct!");
                    break;
                }
            }
        }
    } 
}
