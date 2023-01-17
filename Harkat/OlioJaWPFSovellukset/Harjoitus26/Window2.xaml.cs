using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Harjoitus26
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        //Muuttujat
        static public string ChrName;
        static public string Sex;
        static public string Race;
        private static int Str { get; set; }
        private static int Dex { get; set; }
        private static int Con { get; set; }
        private static int Int { get; set; }
        private static int Wis { get; set; }

        static public string Class;

        static public int FreeStats = 60;

        //Get set pelaajan arvoille, jotta ei ylitetä vapaita arvopisteitä, ja pidetään arvot minimissään yhdessä
        public static int STR
        {
            get { return Str; }
            set
            {
                if (value > FreeStats + STR)
                {
                    value = STR;
                }

                else if (value < 1)
                {
                    value = 1;
                }
                Str = value;
            }
        }
        public static int CON
        {
            get { return Con; }
            set
            {
                if (value > FreeStats + CON)
                {
                    value = CON;
                }

                else if (value < 1)
                {
                    value = 1;
                }
                Con = value;
            }
        }
        public static int DEX
        {
            get { return Dex; }
            set
            {
                if (value > FreeStats + DEX)
                {
                    value = DEX;
                }

                else if (value < 1)
                {
                    value = 1;
                }
                Dex = value;
            }
        }
        public static int WIS
        {
            get { return Wis; }
            set
            {
                if (value > FreeStats + WIS)
                {
                    value = WIS;
                }

                else if (value < 1)
                {
                    value = 1;
                }
                Wis = value;
            }
        }
        public static int INT
        {
            get { return Int; }
            set
            {
                if (value > FreeStats + INT)
                {
                    value = INT;
                }

                else if (value < 1)
                {
                    value = 1;
                }
                Int = value;
            }
        }

        //Alustetaan arvo ruudut kun ikkuna avataan
        public Window2()
        {
            InitializeComponent();
            CharacterNameInput.Text = "";
            Strength.Text = "";
            Constitution.Text = "";
            Dexterity.Text = "";
            Wisdom.Text = "";
            Intelligence.Text = "";
            FreeStatPoints.Text = Convert.ToString(FreeStats);
        }

        //Exit nappulan metodi, lopettaa koko ohjelman
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        //Nappula pelihahmon luonnille, joka toimii vain jos pelaaja on asettanut kaikki vaadittavat arvot pelaajalle
        private void CreateCharacter_Click(object sender, RoutedEventArgs e)
        {
            Message("");
            if (FreeStats == 0 && ChrName != null && Sex != null && Class != null && Race != null)
            {
                Window Win3 = new Window3();
                Win3.Show();
                Close();
            }
            else if (FreeStats > 0)
            {
                Message("You have to spend all your available stat points, before you can create your character");
            }
            else if (ChrName == null)
            {
                Message("You have to give your character a name");
            }
            else if (Sex == null)
            {
                Message("You have to give your character a sex");
            }
            else if (Class == null)
            {
                Message("You have to give your character a class");
            }
            else if (Race == null)
            {
                Message("You have to give your character a race");
            }
            else
            {
                Message("You have spend too many stat points!");
            }
        }
        //Regex käyttämällä voidaan estää pelaajaa syöttämästä muita kun numeroita arvoihin, jolloin ei tarvita koodata mitään
        //virheiden tarkistusta ja virheen palautusta, jos arvo ei ole numeerinen
        private void Strength_Check(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Dexterity_Check(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Constitution_Check(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Intelligence_Check(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Wisdom_Check(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        //Päivitetään ikkunan näkymä
        private void Update()
        {
            StrengthTotal.Text = Convert.ToString(STR);
            DexterityTotal.Text = Convert.ToString(DEX);
            ConstitutionTotal.Text = Convert.ToString(CON);
            IntelligenceTotal.Text = Convert.ToString(INT);
            WisdomTotal.Text = Convert.ToString(WIS);
            FreeStatPoints.Text = Convert.ToString(FreeStats);
            Message("");
        }
        //Syötetään arvot mitkä pelaaja on valinnut tekstibokseista muuttujiin
        private void Allocate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ClassSelection.Text == "Fighter")
                {
                    Class = "Fighter";
                }
                if (SexSelection.Text == "Male")
                {
                    Sex = "Male";
                }
                else if (SexSelection.Text == "Female")
                {
                    Sex = "Female";
                }
                ChrName = CharacterNameInput.Text;
                if (FreeStats > 0)
                {
                    STR = int.Parse(Strength.Text);
                    DEX = int.Parse(Dexterity.Text);
                    CON = int.Parse(Constitution.Text);
                    INT = int.Parse(Intelligence.Text);
                    WIS = int.Parse(Wisdom.Text);
                    FreeStats = 60 - (STR + DEX + CON + WIS + INT);
                    Update();

                    if (FreeStats < 0)
                    {
                        FreeStats = 60;
                        Update();
                        Message("You have allocated too many stat points, 60 is the max!");
                    }
                }
            }
            catch
            {
                Message("None of the stats can be empty");
            }
        }

        //Viestejä varten metodi
        void Message(string message)
        {
            Messages.Text = message;
        }

        //Rodun dropdown menun valintoja varten, joka näyttää pelaajalle rotujen erot viesteillä
        private void RaceSelection_DropDownClosed(object sender, EventArgs e)
        {
            if (RaceSelection.Text == "Human")
            {
                Race = "Human";
                Message("Humans gain no positive or negative traits");
            }
            else if (RaceSelection.Text == "Dwarf")
            {
                Race = "Dwarf";
                Message("Dwafs get +2 to HP every level, but -1 to armor class");
            }
        }
    }
}
