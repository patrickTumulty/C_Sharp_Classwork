using System;
namespace CharacterLibrary
{
    public class InventoryItem
    {
        public InventoryItem(string itemName, uint weight, uint cost)
        {
            ItemName = itemName;
            Weight = "Weight: " + weight.ToString();
            Cost = "Cost: " + cost.ToString();
        }

        public string ItemName { get; set; }

        private string ItemWeight()
        {
            string val = Weight.ToString();
            return "Weight: " + val;
        }

        private string ItemCost()
        {
            return "Cost" + Cost.ToString();
        }

        public string Weight { get; set; }
        public string Cost { get; set; }
    }
}
