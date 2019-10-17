using System;
using System.Threading;
using static System.Console;


namespace AdventureGameV2
{
    static class Utility
    {

        public static void LineConfig(string _words, double _time = 0, ConsoleColor _color = ConsoleColor.White)
        {
            ForegroundColor = _color;
            double milli = _time * 1000; // enter the delay time in seconds, not milliseconds
            Thread.Sleep(Convert.ToInt32(milli));
            WriteLine(_words);
            ResetColor();
        }

        public static void WordConfig(string _words, double _time = 0, ConsoleColor _color = ConsoleColor.White)
        {
            ForegroundColor = _color;
            double milli = _time * 1000;
            Thread.Sleep(Convert.ToInt32(milli));
            Write(_words);
            ResetColor();
        }




    }
}
