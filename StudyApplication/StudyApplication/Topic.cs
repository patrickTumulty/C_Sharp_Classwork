using System;
using static System.Console;
namespace StudyApplication
{
    public class Topic
    {
        // Declare Variables for Topic Class

        public string name;
        public string description;
        public int NumberOfQuestions;
        public string[] questions;
        public string[,] answers;
        public string PlayerAnswer;
        public int QR = 0;

        public Topic()
        {
        
        }

        public void runTest() 
        {
            WriteLine(name);
            WriteLine(description);
            ReadKey();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Question " + (i + 1));
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine(questions[i]);
                ResetColor();
                WriteLine("a. " + answers[i, 0]);
                WriteLine("b. " + answers[i, 1]);
                WriteLine("c. " + answers[i, 2]);
                WriteLine("d. " + answers[i, 3]);
                PlayerAnswer = ReadLine();
                if (PlayerAnswer == answers[i, 4])
                {
                    WriteLine("Correct");
                    QR++; 
                    ReadKey();
                }
                else
                {
                    WriteLine("Wrong");
                    ReadKey();
                }
            }
            // ends with printing your final score 
            WriteLine("You got " + QR + " out of " + NumberOfQuestions + " correct."); 
        }
    }
}
