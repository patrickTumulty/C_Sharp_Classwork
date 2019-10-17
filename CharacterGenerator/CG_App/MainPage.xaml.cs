using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CharacterLibrary;

namespace CG_App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

        Character character;

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            character = new Character();
            character.GenerateCharacter();
            lblName.Text = character.CharacterName;
            lblStrength.Text = character.Strength.ToString();
            lblIntelligence.Text = character.Intelligence.ToString();
            lblDexterity.Text = character.Dexterity.ToString();
            lblWisdom.Text = character.Wisdom.ToString();
            lblConstitution.Text = character.Constitution.ToString();
            lblCharisma.Text = character.Charisma.ToString();
            lblClassSuggestion.Text = character.RecommendClass();
            btnInventory.IsEnabled = true;


        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
             
            Navigation.PushAsync(new InventoryPage(character));
        }
    }
}
