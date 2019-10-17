using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace AdventureGameV2
{
    public class Game
    {
        string fileName = "beginning.txt";
        string[] storyPoints;
        List<string> textLine = new List<string>();
        Object player;

        public Game()
        {
            player = new Character();
            GetData(); // pulls in text from external file
            OpenAnimation();
            BeginStory();
            NextBranch();
        }

        private void OpenAnimation()
        {
            Clear();
            Utility.LineConfig("---------------------------------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("--    -----------------    ------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------------------------------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------_______________---------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------|             |---------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------|             |---------", 0.5, ConsoleColor.Green);
            Utility.WordConfig("---___---|", 0.5, ConsoleColor.Green);
            Utility.WordConfig("     842     ", 0.5, ConsoleColor.Red);
            Utility.WordConfig("|---___---\n", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---| |---|      o      |---| |---", 0.5, ConsoleColor.Green);
            Utility.LineConfig("-  --  --|             |---   ---", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---    --|             |-----  -", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------|         (0) |-  -----", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------|             |---------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("----  ---|             |------ --", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------|             |---------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------|_____________|---------", 0.5, ConsoleColor.Green);
            Utility.LineConfig("---------|             |---------", 0.5, ConsoleColor.Green);
            Utility.LineConfig(".........Welcome to 842..........", 1, ConsoleColor.Red);
            Utility.LineConfig("....Press 'enter' to continue....", 2, ConsoleColor.DarkRed);
            ReadKey();
        }

        private void GetData()
        {
            string[] storyPoints = File.ReadAllText(fileName).Split('/');
            foreach (string item in storyPoints)
            {
                textLine.Add(item);
            }
        }

        public void BeginStory()
        {
            Utility.LineConfig(textLine[0], 0.5, ConsoleColor.Yellow);
            Utility.LineConfig(textLine[1], 3, ConsoleColor.Green);
            string a = ReadLine().ToLower();
            if (a == "investigate")
            {
                Utility.LineConfig(textLine[2], 0.5, ConsoleColor.Yellow);
                Character.inventory.Add("note: YOUARESPECIAL");
                Utility.LineConfig("The note has been added to your inventory", 5, ConsoleColor.Cyan);
                Character.ShowInventory();
                Utility.LineConfig(textLine[3], 3, ConsoleColor.Green);
                a = ReadLine().ToLower();
                if (a == "run")
                {
                    Utility.LineConfig(textLine[4] + "\n", 0.5, ConsoleColor.Yellow); // dream sequence
                    Utility.LineConfig(textLine[0] + "\n", 3, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[5] + "\n", 3, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[1] + "\n", 2, ConsoleColor.Green);
                    a = ReadLine().ToLower();
                    if (a == "investigate")
                    {
                        Utility.LineConfig(textLine[7], 1, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[10], 2, ConsoleColor.Green);
                        a = ReadLine().ToLower();
                        if (a == "walk")
                        {
                            Utility.LineConfig(textLine[6], 1, ConsoleColor.Yellow);
                            Utility.LineConfig(textLine[9], 2, ConsoleColor.Green);
                            a = ReadLine();
                            if (a == "YOUARESPECIAL")
                            {
                                NextBranch();
                            }
                        }
                    }
                    else if (a == "walk")
                    {
                        Utility.LineConfig(textLine[6], 1, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[9], 2, ConsoleColor.Green);
                        a = ReadLine();
                        if (a == "YOUARESPECIAL")
                        {
                            NextBranch();
                        }
                    }
                }
            }
            else if (a == "walk")
            {
                Utility.LineConfig(textLine[6], 1, ConsoleColor.Yellow);
                Utility.LineConfig(textLine[8], 1, ConsoleColor.Green);
                a = ReadLine().ToLower();
                Utility.LineConfig(textLine[2], 0.5, ConsoleColor.Yellow);
                Character.inventory.Add("note: YOUARESPECIAL");
                Utility.LineConfig("The note has been added to your inventory", 5, ConsoleColor.Cyan);
                Character.ShowInventory();
                Utility.LineConfig(textLine[3], 3, ConsoleColor.Green);
                a = ReadLine().ToLower();
                if (a == "run")
                {
                    Utility.LineConfig(textLine[4] + "\n", 0.5, ConsoleColor.Yellow); // dream sequence
                    Utility.LineConfig(textLine[0] + "\n", 1, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[5] + "\n", 2, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[1] + "\n", 2, ConsoleColor.Green);
                    a = ReadLine().ToLower();
                    if (a == "investigate")
                    {
                        Utility.LineConfig(textLine[7], 1, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[10], 2, ConsoleColor.Green);
                        a = ReadLine().ToLower();
                        if (a == "walk")
                        {
                            Utility.LineConfig(textLine[6], 1, ConsoleColor.Yellow);
                            Utility.LineConfig(textLine[9], 2, ConsoleColor.Green);
                            a = ReadLine();
                            if (a == "YOUARESPECIAL")
                            {
                                NextBranch();
                            }
                        }
                    }
                    else if (a == "walk")
                    {
                        Utility.LineConfig(textLine[6], 1, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[9], 2, ConsoleColor.Green);
                        a = ReadLine();
                        if (a == "YOUARESPECIAL")
                        {
                            NextBranch();
                        }
                    }
                }
            }
        }
        private void NextBranch()
        {
            Clear();
            Utility.LineConfig("=======================================================", 1, ConsoleColor.Yellow);
            Utility.LineConfig(textLine[11], 0.5, ConsoleColor.Yellow);
            for (int i = 0; i < Character.inventory.Count; i++)
            {
                if (Character.inventory[i] == "Flashlight")
                {
                    Utility.LineConfig(textLine[12], 2, ConsoleColor.Yellow);
                    FlashlightPath();
                }
                else if (Character.inventory[i] == "Lighter")
                {
                    Utility.LineConfig(textLine[13], 2, ConsoleColor.Yellow);
                    LighterPath();
                }
                else if (Character.inventory[i] == "Rope")
                {
                    Utility.LineConfig(textLine[33], 2, ConsoleColor.Yellow);
                    LighterPath();
                }
            }
        }

        private void FlashlightPath()
        {
            Utility.LineConfig("Press enter to continue", 1, ConsoleColor.Green);
            ReadKey();
            Utility.LineConfig(textLine[14], 2, ConsoleColor.Yellow);
            Utility.LineConfig("\nWelcome back " + Character.playerName + ".", 4, ConsoleColor.Red);
            Utility.LineConfig(textLine[15], 3, ConsoleColor.Yellow);
            Utility.LineConfig(textLine[16], 2, ConsoleColor.Green);
            string a = ReadLine().ToLower();
            if (a == "look")
            {
                Utility.LineConfig(textLine[17], 0.5, ConsoleColor.Yellow);
                Utility.LineConfig(textLine[18], 0.5, ConsoleColor.Green);
                a = ReadLine().ToLower();
                if (a == "walk")
                {
                    Utility.LineConfig(textLine[19], 0.5, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[20], 1, ConsoleColor.Green);
                    a = ReadLine().ToLower();
                    if (a == "push")
                    {
                        Utility.LineConfig(textLine[21], 0.5, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[22], 1, ConsoleColor.Green);
                        a = ReadLine().ToLower();
                        if (a == "push")
                        {
                            Utility.LineConfig(textLine[23], 0.5, ConsoleColor.Yellow);
                            Utility.LineConfig("\nThe post it reads... ", 4, ConsoleColor.Yellow);
                            Utility.LineConfig("Remember " + Character.playerName + " You are special.", 2, ConsoleColor.Red);
                        }
                    }
                }
            }
            Utility.LineConfig(textLine[24], 0.5, ConsoleColor.Green);
            a = ReadLine().ToLower();
            if (a == "descend")
            {
                Utility.LineConfig(textLine[25], 6, ConsoleColor.Yellow);
                Utility.LineConfig(textLine[26], 6, ConsoleColor.Yellow);
                Utility.LineConfig(textLine[27], 6, ConsoleColor.Yellow);
                Utility.LineConfig(textLine[28], 6, ConsoleColor.Red);
                Utility.LineConfig(textLine[29], 4, ConsoleColor.Red);
                Utility.LineConfig(textLine[30], 6, ConsoleColor.Yellow);
                Utility.LineConfig(textLine[31], 6, ConsoleColor.Yellow);
                Utility.LineConfig("Press enter to continue", 4, ConsoleColor.Green);
                ReadKey();
                Clear();
                Utility.LineConfig(textLine[32], 4, ConsoleColor.Yellow);
                Utility.LineConfig("\nThe PostIt note reads " , 2, ConsoleColor.Yellow);
                Utility.LineConfig("\nYou Are Special", 2, ConsoleColor.Cyan);
                ReadKey();
            }
        }

        private void LighterPath()
        {
            Utility.LineConfig(textLine[34], 0.5, ConsoleColor.Yellow);
            Utility.LineConfig("\nType climb to climb up the stairs.", 2, ConsoleColor.Green);
            string a = ReadLine().ToLower();
            if (a == "climb")
            {
                Utility.LineConfig(textLine[35], 0.5, ConsoleColor.Yellow);
                if (Character.inventory.Contains("Lighter"))
                {
                    Utility.LineConfig(textLine[36], 2, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[37], 2, ConsoleColor.Green);
                    a = ReadLine().ToLower();
                    if (a == "chuck")
                    {
                        Utility.LineConfig(textLine[38], 2, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[39], 3, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[40], 3, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[41], 3, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[42], 3, ConsoleColor.Yellow);
                    }
                    else if (a == "keep")
                    {
                        Utility.LineConfig(textLine[43], 2, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[44], 3, ConsoleColor.Yellow);
                        Utility.LineConfig(textLine[45], 3, ConsoleColor.Green);
                        a = ReadLine().ToLower();
                        if ( a == "open")
                        {
                            Utility.LineConfig(textLine[46], 3, ConsoleColor.Yellow);
                            Utility.LineConfig(textLine[47], 3, ConsoleColor.Green);
                            a = ReadLine().ToLower();
                            if ( a == "get up")
                            {
                                Utility.LineConfig(textLine[48], 3, ConsoleColor.Yellow);
                            }
                        }
                    }
                    Utility.LineConfig(textLine[49], 3, ConsoleColor.Yellow);
                    Utility.LineConfig("\n" + Character.playerName + ", You Are Special.", 20, ConsoleColor.Cyan);
                    for (int i = 0; i < 3; i++)
                    {
                        Utility.LineConfig("\n" + textLine[50], 4, ConsoleColor.Red);
                    }
                }
                else if (Character.inventory.Contains("Rope"))
                {
                    Utility.LineConfig("Press enter to continue", 3, ConsoleColor.Green);
                    ReadKey();
                    Utility.LineConfig(textLine[51], 1, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[52], 3, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[53], 1, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[39], 5, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[40], 3, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[41], 3, ConsoleColor.Yellow);
                    Utility.LineConfig(textLine[42], 3, ConsoleColor.Yellow);
                    Utility.LineConfig("Press enter to continue", 3, ConsoleColor.Green);
                    ReadKey();
                    Utility.LineConfig(textLine[49], 3, ConsoleColor.Yellow);
                    Utility.LineConfig("\n" + Character.playerName + ", You Are Special.", 20, ConsoleColor.Cyan);
                    for (int i = 0; i < 3; i++)
                    {
                        Utility.LineConfig("\n" + textLine[50], 4, ConsoleColor.Red);
                    }
                }
            }

        }
    }
}
