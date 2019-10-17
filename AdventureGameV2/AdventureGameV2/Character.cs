using System;
using System.Collections.Generic;
using static System.Console;

namespace AdventureGameV2
{
    public class Character
    {
        public static string playerName;
        public static List<string> inventory = new List<string>();
        string[] startingItems = { "Flashlight", "Lighter", "Rope" };

        public Character()
        {
            CharacterConfig();
        }

        private void CharacterConfig()
        {
            WriteLine("What is your name?");
            playerName = ReadLine();
            Utility.LineConfig("Hello " + playerName, 0.5, ConsoleColor.Cyan);
            WriteLine("Choose an item to take with you... ");
            for (int i = 0; i < startingItems.Length; i++)
            {
                Utility.LineConfig(startingItems[i], 0.5, ConsoleColor.Cyan);
            }
            Utility.LineConfig("Choose Wisely", 0.5, ConsoleColor.Red);
            string a = ReadLine().ToLower();
            if (a == "flashlight")
            {
                inventory.Add(startingItems[0]);
            }
            else if (a == "lighter")
            {
                inventory.Add(startingItems[1]);
            }
            else if (a == "rope")
            {
                inventory.Add(startingItems[2]);
            }
            ShowInventory();
        }

        public static void ShowInventory()
        {
            WriteLine("\n---Player Inventory---");
            for (int i = 0; i < inventory.Count; i++)
            {
                Utility.LineConfig(inventory[i], 0.25, ConsoleColor.Yellow);
            }
        }
    }
}
