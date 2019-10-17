using System;
using static System.Console;

namespace StudyApplication
{
    class MainClass
    {
        public static void Main()
        {
            WriteLine("Press 'a' to take a quiz");
            WriteLine("Press 'b' to study terms");
            string input = ReadLine();
            if (input == "a")
            {
                Player player1 = new Player();
            }
            if (input == "b")
            {
                termDefs start = new termDefs();
            }


        }
    }
}
