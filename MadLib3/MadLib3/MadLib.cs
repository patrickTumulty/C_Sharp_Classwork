using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace MadLib3
{
    public class MadLib
    {

        string[] image = {"──────────────────────────────",
                          "──────────────────────────────",
                          "──────────────────────────────",
                          "──────────────────────────────",
                          "─▗▄▄▄───▄▄▄───▄▄▄▄──▗▄▄▄▄▄▄▖──",
                          "─█──▐█──▛▀▀───▌───▖──▄─█▌─────",
                          "─▙▄▄▟█──▌─────▙▄▖─█▄─█─█▌─────",
                          "─▛▀▀▜█──▌▝▀█▖─▌───▌▝▙█─█▌─────",
                          "▗▌──▐█──▙▄▄█▌─▙▄▄▖▌─▝█─█▌─────",
                          "──────────────────────────────",
                          "──────────────────────────────",
                          "──────────────────────────────",
                          "──────────────────────────────",
                          "──────────────────────────────",
                          "─────────────────────────────"};
     

        string[] Prompts = // list of prompts
        {
            "Persons Name: ",
            "Present Tense Verb: ",
            "Professional Title: ",
            "A Last Name: ",
            "Noun: ",
            "An Object: ",
            "Adjective: ",
            "Adjective: ",
            "Plural Noun: ",
            "Noun: "
        };
        List<string> words = new List<string>();  // list that I can add player answers to

        /*
         * Agent name, your mission, should you choose to accept it, is to infiltrate
         * the residential esstate of prime minister name. Once your inside your task will be
         * to take pictures of any import documents, plant evidense, and escape unseen. The fate 
         * of many people in location are counting on you.         
         */

        public MadLib()
        {
            PrintImage();
            Thread.Sleep(1000);
            GetTerms();
        }

        public void GetTerms()
        {
            Clear();
           for (int i = 0; i < Prompts.Length; i++) // loop to add player input to list and to iterate through prompts
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine(Prompts[i]);
                ForegroundColor = ConsoleColor.Blue;
                string a = ReadLine();
                words.Add(a);
            }
            Clear();
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Compiling Story... ");
            Thread.Sleep(2000);
            Clear();
            PrintMadLib();
        }

        public void PrintImage()
        {
            for (int i = 0; i < image.Length; i++)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine(image[i]);
                Thread.Sleep(400);
                ResetColor();
            }
        }

        public void PrintMadLib()
        {
            ResetColor();
            Write("Agent ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[0]);
            ResetColor();
            Write("\nYour mission, should you ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[1]);
            ResetColor();
            Write(" to accept it, \nIs to infiltrate ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[2]);
            Write(" " + words[3] + "'s");
            ResetColor();
            Write(" residential estate. \nOnce inside your will need to \ntake out the ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[4]);
            ResetColor();
            Write("\nBreak into the ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[5]);
            ResetColor();
            Write(" and plant ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[6]);
            ResetColor();
            Write(" evidence. \nIt is important that you make a ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[7]);
            ResetColor();
            Write(" escape. \nThe fate of many ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[8]);
            ResetColor();
            Write(" rests in your ");
            ForegroundColor = ConsoleColor.Green;
            Write(words[9]);
            ResetColor();
            Write(".");
            WriteLine("\n\nWould you like to play again?");
            WriteLine("Press a to play again");
            WriteLine("Press enter to exit");
            string a = ReadLine().ToLower();
            if (a == "a")
            {
                MainClass.Main(); 
            }
        }
    }
}
