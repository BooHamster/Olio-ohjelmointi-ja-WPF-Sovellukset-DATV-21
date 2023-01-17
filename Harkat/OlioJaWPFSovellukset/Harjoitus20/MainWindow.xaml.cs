using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Robert Kajanti
namespace Harjoitus20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadFromFile(); //Käynnistää metodin joka lataa tiedot mitkä on tallennettu tekstitiedostoon
        }

        private void OpiskelijaIDValidation(object sender, TextCompositionEventArgs e) //OpiskelijaID:en tarkistamisen metodi, joka tarkistaa, että annettu ID on vain numeroita, ja ei anna syöttää mitään muuta kuin numeroita
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnAddOpiskelija_Click(object sender, RoutedEventArgs e) //Metodi Lisää Opiskelija napille, mikä aloittaa Metodin staattisen KokoelmaManageri luokan sisältä
        {
            string etunimi = etunimiInput.Text;
            string sukunimi = sukunimiInput.Text;
            string opiskelijaID = opiskelijaIDInput.Text;

            if (etunimi.Length < 2 || sukunimi.Length < 2 || opiskelijaID.Length < 2) //If lause mikä pakottaa käyttäjän tekemään opiskelijan nimistä ja OpiskelijaID:stä tarpeeksi pitkät
            {
                SetActivityMessage("Syötit liian lyhyen Etunimen, Sukunimen tai OpiskelijaID:en, kaikkien näiden on oltava vähintään 2 merkkiä pitkät");
                return;
            }

            try
            {
                if (KokoelmaManageri.TarkistaID(opiskelijaID)) //If lause suorittaa staattisen luokan metodin joka tarkistaa onko OpiskelijaID uniikki, ja suorittaa if lauseen sisällön jos ID on uniikki, muuten se palauttaa virhelauseen
                {
                    KokoelmaManageri.LisääOpiskelija(etunimi, sukunimi, opiskelijaID); //Suorittaa staattisen luokan metodin, joka lisää uuden Opiskelijan Opiskelija kokoelmaan
                    SetActivityMessage("Uusi opiskelija lisätty kokoelmaan: " + KokoelmaManageri.Opiskelijat[opiskelijaID].HaeData());
                }
            }
            catch (Exception ex)
            {
                SetActivityMessage(ex.Message);
            }
            finally
            {
                ClearInputFields();
            }

            RefreshGrid();
        }

        private void ClearInputFields() //Metodi joka tyhjentää tekstisyöttökentät
        {
            etunimiInput.Text = "";
            sukunimiInput.Text = "";
            opiskelijaIDInput.Text = "";
        }

        private void RefreshGrid() //Metodi joka suorittaa staattisenluokan metodin joka palauttaa tallennetut opiskelijat kokoelmasta datagridiin
        {
            OpiskelijatGrid.ItemsSource = KokoelmaManageri.PalautaOpiskelijat();
        }

        private void btnDeleteSelected_Click(object sender, RoutedEventArgs e) //Metodi joka suorittaa staattisesta luokasta metodin joka poistaa datagridistä valitut opiskelijat Opiskelijat Kokoelmasta
        {

            string poistetutOpiskelijat = "";

            foreach (Opiskelija opiskelija in OpiskelijatGrid.ItemsSource)
            {
                if (opiskelija.IsSelected)
                {
                    poistetutOpiskelijat += " " + opiskelija.Etunimi + " " + opiskelija.Sukunimi + ", ";
                    KokoelmaManageri.PoistaOpiskelija(opiskelija);
                }
            }

            if (poistetutOpiskelijat.Equals(""))
                return;

            SetActivityMessage("Opiskelijat" + poistetutOpiskelijat + " poistettu kokoelmasta");

            RefreshGrid();
        }

        void SetActivityMessage(string message) //Erilaisten viestien tulostukseen tekstiblokiin, jonka tarkoitus on 
        {
            activityMessage.Text = message;
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            LoadFromFile();
        }
        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveToFile();
        }

        private void LoadFromFile() //Metodi joka käyttää staattisenluokan metodia lataamaan tiedostoon tallennetut tiedot
        {
            string loadSuccessfulMessage = KokoelmaManageri.LoadFromFile();

            if (loadSuccessfulMessage == "")
            {
                SetActivityMessage("Opiskelija Kokoelma on haettu tiedostosta onnistuneesti!");
                RefreshGrid();
            }
            else
            {
                SetActivityMessage("Tiedoston lataaminen ei onnistunut, error: " + loadSuccessfulMessage);
            }
        }

        private void SaveToFile() //Metodi joka käyttää staattisenluokan metodia tallentamaan Opiskelija kokoelma tiedostoon
        {
            string saveSuccessfulMessage = KokoelmaManageri.SaveToFile();

            if (saveSuccessfulMessage == "")
            {
                SetActivityMessage("Opiskelija Kokoelma on tallennettu tieodstoon!");
            }
            else
            {
                SetActivityMessage("Tiedostoon tallentaminen ei onnistunut, error: " + saveSuccessfulMessage);
            }
        }
    }
}
