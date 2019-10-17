using System;
using static System.Console;


namespace StudyApplication
{
    public class Player
    {
        string PlayerName;
        public int QCorrect = 0;

        public Player()  // Custom constructor, one arguement, adds player name
        {
            WriteLine("What is your name?:");
            PlayerName = ReadLine();
            WriteLine("Hello " + PlayerName);
            StartQuiz();
        }

         
        public void StartQuiz()
        {
            Topic AudioQuest = new Topic();
            AudioQuest.name = "Audio Quiz";
            AudioQuest.description = "Test Your Audio Knowledge";
            AudioQuest.NumberOfQuestions = 3;
            AudioQuest.questions = new string[] { "What is frequency measured in?", "Is our perception of pitch linear?", 
            "What best describes the .WAV file format" };
            AudioQuest.answers = new string[,] { { "Hz", "Meters", "Seconds", "Decibels", "a" }, { "Yes", "No", "Depends", "Pitch is subjective", "b" },
            {"Lossy Compressed", "Lossless Compressed", "Lossless Uncompressed", "Lossy Uncompressed", "c"} };
            QCorrect += AudioQuest.QR;

            Topic JamesBond = new Topic();
            JamesBond.name = "James Bond Quiz";
            JamesBond.description = "You think you know James Bond? Test Your Knowledge!!!";
            JamesBond.NumberOfQuestions = 3;
            JamesBond.questions = new string[] {"How many actors have played James Bond?", "Which actor played James Bond in only one film?",
            "In Austin Powers Goldmember, Random Task is a direct spoof of which famous bond villain?"};
            JamesBond.answers = new string[,] { {"8", "4", "6", "5", "c"}, {"Roger Moore", "George Lazenby", "Timothy Dalton", "Sean Connery", "b"},
            {"Oddjob", "Nick Nack", "Mr. Hinx", "Baron Samedi", "a"} };
            QCorrect += JamesBond.QR;

            WriteLine("Select Your Quiz:");
            WriteLine("Press a for " + AudioQuest.name);
            WriteLine("Press b for " + JamesBond.name);
            string input = ReadLine();
            if (input == "a")
            {
                AudioQuest.runTest();  // Initilization of the parent class
            }
            if (input == "b")
            {
                JamesBond.runTest();
            }
            WriteLine("Would you like to take another quiz?");
            WriteLine("a to continue");
            WriteLine("b to quit");
            string enter = ReadLine();
            if (enter == "a")
            {
                StartQuiz();
            }
        }
    }
}
