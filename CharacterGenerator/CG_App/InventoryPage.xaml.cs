using System;
using System.Collections.Generic;
using CharacterLibrary;
using Xamarin.Forms;

namespace CG_App
{
    public partial class InventoryPage : ContentPage
    {
        private Character character;

        public InventoryPage()
        {
            InitializeComponent();

        }

        public InventoryPage(Character c)
        {
            InitializeComponent();
            character = c;
            lstItems.ItemsSource = character.Inventory;

           
        }


    }
}
