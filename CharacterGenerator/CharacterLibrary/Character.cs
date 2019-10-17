using System;
using System.Text;
using System.Collections.Generic;


namespace CharacterLibrary
{
    public class Character
    {
        public Character()
        {
            _strength = 3;
            _intelligence = 3;
            _wisdom = 3;
            _dexterity = 3;
            _constitution = 3;
            _charisma = 3;

            randomNames = new string[5] { "Frodo", "Bilbo", "Dori", "Nori", "Gandalf" };
            Inventory = new List<InventoryItem>();
        }

        public Character(string name)
        {
            CharacterName = name; 
        }

        private string[] randomNames;
        private Random rnd = new Random();
        public string CharacterName { get; set; }
        private int _strength;
        private int _intelligence;
        private int _wisdom;
        private int _dexterity;
        private int _constitution;
        private int _charisma;


        public int Strength
        {
            get { return _strength; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _strength = value;
                }
                else
                {
                    throw new Exception("Strength must be between 3 and 18.");
                }
            }
        }

        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _intelligence = value;
                }
                else
                {
                    throw new Exception("Intelligence must be between 3 and 18.");
                }
            }
        }

        public int Wisdom
        {
            get { return _wisdom; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _wisdom = value;
                }
                else
                {
                    throw new Exception("Wisdom must be between 3 and 18.");
                }
            }
        }

        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _dexterity = value;
                }
                else
                {
                    throw new Exception("Dexterity must be between 3 and 18.");
                }
            }
        }

        public int Constitution
        {
            get { return _constitution; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _constitution = value;
                }
                else
                {
                    throw new Exception("Consitution must be between 3 and 18.");
                }
            }
        }

        public int Charisma
        {
            get { return _charisma; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _charisma = value;
                }
                else
                {
                    throw new Exception("Charisma must be between 3 and 18.");
                }
            }
        }

        public int ExperiencePoints { get; set; }
        public int Level { get { return int.Parse(Math.Floor(ExperiencePoints / 1000d).ToString()); } }

        public List<InventoryItem> Inventory { get; set; }

        public void AddInventoryItem(InventoryItem item)
        {
            Inventory.Add(item);
        } 

        private int RollAttributeScore()
        {
            int score = 0;
            int highestScore = 0;
            for (var i = 0; i < 3; i++)
            {
                score = rnd.Next(3, 18);
                if (score > highestScore)
                {
                    highestScore = score;
                }
            }
            return highestScore;
        }

        public void GenerateCharacter()
        {
            CharacterName = GetRandomName();
            Strength = RollAttributeScore();
            Intelligence = RollAttributeScore();
            Wisdom = RollAttributeScore();
            Dexterity = RollAttributeScore();
            Constitution = RollAttributeScore();
            Charisma = RollAttributeScore();

            // everyone gets a cloak, staff and torch
            Inventory.Clear();
            var Cloak = new InventoryItem("Cloak", 4, 2);
            var Staff = new InventoryItem("Staff", 3, 4);
            var Torch = new InventoryItem("Torch", 1, 1);
            Inventory.Add(Cloak);
            Inventory.Add(Staff);
            Inventory.Add(Torch);
        }

        public string RecommendClass()
        {
            var recommendation = new StringBuilder();

            if (Strength > 12)
            {
                recommendation.AppendLine("This character would make a good fighter");
            }

            if (Intelligence > 14)
            {
                recommendation.AppendLine("This character should be a magic user");
            }
            else
            {
                recommendation.AppendLine("Maybe " + CharacterName + " shouldn't be a magic user.");
            }

            if (Intelligence > 12 && Wisdom > 12)
            {
                recommendation.AppendLine("This character should weild magic");
            }

            if (Strength > 12 || Dexterity > 12)
            {
                recommendation.AppendLine("This character might make a good theif");
            }

            return recommendation.ToString();
        }

        public override string ToString()
        {
            var CharacterString = new StringBuilder();
            CharacterString.AppendLine("Character Name: " + CharacterName);
            CharacterString.AppendLine("Strength: " + Strength);
            CharacterString.AppendLine("Intelligence: " + Intelligence);
            CharacterString.AppendLine("Wisdom: " + Wisdom);
            CharacterString.AppendLine("Dexterity: " + Dexterity);
            CharacterString.AppendLine("Constitution: " + Constitution);
            CharacterString.AppendLine("Charisma: " + Charisma);
            CharacterString.AppendLine("------------- Inventory -------------");
            foreach (var item in Inventory)
            {
                CharacterString.AppendLine("Item Name: " + item.ItemName);
                CharacterString.AppendLine("Item Weight: " + item.Weight + " lbs");
                CharacterString.AppendLine("Item Cost: " + item.Cost + "gp");
                CharacterString.AppendLine("------------------------------------");
            }
            CharacterString.AppendLine(RecommendClass());
            return CharacterString.ToString();

        }

        private string GetRandomName()
        {
            var randomIndex = rnd.Next(0, randomNames.Length);
            return randomNames[randomIndex];
        }


    }
}
