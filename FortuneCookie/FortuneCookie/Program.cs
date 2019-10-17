using System;
using static System.Console;

namespace FortuneCookie
{
    class MainClass
    {

        public static void Main()
        {
            Title = "Fortune";
            Fortune fortune = new Fortune();
            WriteLine("Press enter to exit.");
            ReadKey();
        }

    }
}
