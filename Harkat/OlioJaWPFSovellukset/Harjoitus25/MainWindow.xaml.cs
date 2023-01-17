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
using System.Windows.Navigation;
using System.Windows.Shapes;
//Robert Kajanti
namespace Harjoitus25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Luodaan 4 Joukkue luokkaa käyttävää oliota
        Joukkue Jokerit = new Joukkue("Jokerit", "Helsinki");
        Joukkue TPS = new Joukkue("TPS", "Turku");
        Joukkue Tappara = new Joukkue("Tappara", "Tampere");
        Joukkue Kärpät = new Joukkue("Kärpät", "Oulu");
        public MainWindow()
        {
            InitializeComponent();
            TyhjennäKentät(); //Tekstikenttien tyhjennykseen tarkoitettu metodi
        }

        private void PelaajaNumeroTeksti_PreviewTextInput(object sender, TextCompositionEventArgs e) //Pelaajanumero syöttökenttään metodi joka tarkastaa, että syötetyt merkit on numeroita, se estää muiden merkkien syöttämisen
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void LisääPelaaja_Click(object sender, RoutedEventArgs e) //Pelaajan lisäämiseen metodi
        {
            //Muuttujat joihin tallennetaan pelaaja oliolle tallennettavat arvot
            string etunimi = EtunimiTeksti.Text;
            string sukunimi = SukunimiTeksti.Text;
            int pelaajanumero = int.Parse(PelaajaNumeroTeksti.Text);

            if (etunimi.Length < 2 || sukunimi.Length < 2 || pelaajanumero < 0 || pelaajanumero > 99) //If joka pitää huolta Pelaaja olion muuttujien pysymisen kriteereiden sisällä
            {
                return;
            }

            try
            {
                if (JoukkueenValinta.SelectedIndex == 0) //If lause joka tarkastaa mikä joukkue on valittuna
                {
                    if (Jokerit.TarkistaPelaajaNumero(pelaajanumero)) //If lause pelaajanumeron tarkistamiseen joukkueesta
                    {
                        Jokerit.Lisää(etunimi, sukunimi, pelaajanumero); //Metodi Pelaajan lisäämiseen joukkueeseen
                        Viesti("Uusi Pelaaja lisätty joukkueeseen Jokerit: " + Jokerit.Pelaajat[pelaajanumero].Tiedot()); //Viesti joka kertoo kuka pelaaja on lisätty joukkueeseen
                    }
                }
                else if (JoukkueenValinta.SelectedIndex == 1)
                {
                    if (TPS.TarkistaPelaajaNumero(pelaajanumero))
                    {
                        TPS.Lisää(etunimi, sukunimi, pelaajanumero);
                        Viesti("Uusi Pelaaja lisätty joukkueeseen TPS: " + TPS.Pelaajat[pelaajanumero].Tiedot());
                    }
                }
                else if (JoukkueenValinta.SelectedIndex == 2)
                {
                    if (Tappara.TarkistaPelaajaNumero(pelaajanumero))
                    {
                        Tappara.Lisää(etunimi, sukunimi, pelaajanumero);
                        Viesti("Uusi Pelaaja lisätty joukkueeseen Tappara: " + Tappara.Pelaajat[pelaajanumero].Tiedot());
                    }
                }
                else if (JoukkueenValinta.SelectedIndex == 3)
                {
                    if (Kärpät.TarkistaPelaajaNumero(pelaajanumero))
                    {
                        Kärpät.Lisää(etunimi, sukunimi, pelaajanumero);
                        Viesti("Uusi Pelaaja lisätty joukkueeseen Kärpät: " + Kärpät.Pelaajat[pelaajanumero].Tiedot());
                    }
                }

            }
            catch (Exception ex) //Ilmoitus virheitä varten
            {
                Viesti(ex.Message);
            }
            finally
            {
                TyhjennäKentät(); //Käytetään tekstikenttien tyhjennys metodia
            }
            PäivitäNäkymä(); //Käyttää metodia joka päivittää näkymään uudet tiedot
        }

        private void TyhjennäKentät() //Metodi joka tyhjentää tekstikentät
        {
            EtunimiTeksti.Text = "";
            SukunimiTeksti.Text = "";
            PelaajaNumeroTeksti.Text = "";
        }

        private void PäivitäNäkymä() //Metodi joka päivittää joukkueiden tiedot kun uusi joukkue valitaan, tai joukkuetta vaihdetaan
        {
            BitmapImage bi3 = new BitmapImage(); //Luodaan kuvalle muuttuja
            bi3.BeginInit(); //Aktivoidaan kuva muuttuja
            if (JoukkueenValinta.SelectedIndex == 0)
            {
                PelaajaGrid.ItemsSource = Jokerit.NäytäPelaajat(); //Päivitetään Gridiin pelaajatiedot
                bi3.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/fi/7/7c/Jokerit_logo_2019.png", UriKind.Absolute); //Annetaan kuva muuttujalle lähde
                bi3.EndInit();  //Lopettaa kuvan aktivoimisen
            }
            else if (JoukkueenValinta.SelectedIndex == 1)
            {
                PelaajaGrid.ItemsSource = TPS.NäytäPelaajat();
                bi3.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/fi/thumb/6/62/Turun_Palloseuran_logo.svg/1010px-Turun_Palloseuran_logo.svg.png", UriKind.Absolute);
                bi3.EndInit();
            }
            else if (JoukkueenValinta.SelectedIndex == 2)
            {
                PelaajaGrid.ItemsSource = Tappara.NäytäPelaajat();
                bi3.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/fi/thumb/3/32/Tapparan_logo.svg/1200px-Tapparan_logo.svg.png", UriKind.Absolute);
                bi3.EndInit();
            }
            else if (JoukkueenValinta.SelectedIndex == 3)
            {
                PelaajaGrid.ItemsSource = Kärpät.NäytäPelaajat();
                bi3.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/fi/thumb/a/aa/Oulun_K%C3%A4rp%C3%A4t_logo.svg/1200px-Oulun_K%C3%A4rp%C3%A4t_logo.svg.png", UriKind.Absolute);
                bi3.EndInit();
            }
            JoukkueKuva.Stretch = Stretch.Fill; //Venyttää valitun kuvaa kunnes se täyttää kuva objektin ikkunassa
            JoukkueKuva.Source = bi3; //Valitaan kuva objektille kuva muuttuja
        }

        void Viesti(string message)
        {
            Viestit.Text = message;
        }

        private void PoistaPelaaja_Click(object sender, RoutedEventArgs e) //Pelaajan poistamiseen metodi
        {
            string poistetutPelaajat = "";

            foreach (Pelaaja pelaaja in PelaajaGrid.ItemsSource) //Suorittaa jokaiselle gridissä valitulle pelaajalle pelaajan poistamisen metodin
            {
                if (JoukkueenValinta.SelectedIndex == 0) //Tarkistaa mikä joukkue valittuna
                {
                    if (pelaaja.Valittuna) //Tarkistaa jos pelaaja on valittuna gridissä
                    {
                        poistetutPelaajat += " " + pelaaja.Etunimi + " " + pelaaja.Sukunimi + ", "; //Lisää string muuttujaan pelaajan tiedot
                        Jokerit.PoistaPelaaja(pelaaja); //Suorittaa varsinaisen pelaajan poistometodin, joka löytyy joukkue oliosta 
                    }
                }
                else if (JoukkueenValinta.SelectedIndex == 1)
                {
                    if (pelaaja.Valittuna)
                    {
                        poistetutPelaajat += " " + pelaaja.Etunimi + " " + pelaaja.Sukunimi + ", ";
                        TPS.PoistaPelaaja(pelaaja);
                    }
                }    
                else if (JoukkueenValinta.SelectedIndex == 2)
                {
                    if (pelaaja.Valittuna)
                    {
                        poistetutPelaajat += " " + pelaaja.Etunimi + " " + pelaaja.Sukunimi + ", ";
                        Tappara.PoistaPelaaja(pelaaja);
                    }
                }  

                else if (JoukkueenValinta.SelectedIndex == 3)
                {
                    if (pelaaja.Valittuna)
                    {
                        poistetutPelaajat += " " + pelaaja.Etunimi + " " + pelaaja.Sukunimi + ", ";
                        Kärpät.PoistaPelaaja(pelaaja);
                    }
                }

            }

            if (poistetutPelaajat.Equals("")) //Jos mitään pelaajia ei ole valittuna, metodi loppuu tekemättä mitään
            {
                return;
            }

            Viesti("Pelaajat" + poistetutPelaajat + " poistettu Joukkueesta"); //Näyttää poistetutPelaajat string muuttujan tekstin keskellä

            PäivitäNäkymä(); //Päivittää näkymän
        }

        private void Tallenna_Click(object sender, RoutedEventArgs e) //Tietojen tallennukseen metodi tallennus nappulaa käyttäen
        {
            SaveToFile();
        }
        private void Lataa_Click(object sender, RoutedEventArgs e) //Tietojen lataamiseen metodi lataus nappulaa käyttäen
        {
            LoadFromFile();
        }

        private void LoadFromFile() //Tietojen lataamiseen metodi
        {
            if (JoukkueenValinta.SelectedIndex == 0)
            {
                string loadSuccessfulMessage = Jokerit.LoadFromFile(); //Metodi joka lataa pelaajatiedot tiedostosta

                if (loadSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on ladattu onnistuneesti!");
                    PäivitäNäkymä();
                }
                else
                {
                    Viesti("Tiedoston lataaminen ei onnistunut, error: " + loadSuccessfulMessage);
                }
            }

            else if (JoukkueenValinta.SelectedIndex == 1)
            {
                string loadSuccessfulMessage = TPS.LoadFromFile();

                if (loadSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on ladattu onnistuneesti!");
                    PäivitäNäkymä();
                }
                else
                {
                    Viesti("Tiedoston lataaminen ei onnistunut, error: " + loadSuccessfulMessage);
                }
            }

            else if (JoukkueenValinta.SelectedIndex == 2)
            {
                string loadSuccessfulMessage = Tappara.LoadFromFile();

                if (loadSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on ladattu onnistuneesti!");
                    PäivitäNäkymä();
                }
                else
                {
                    Viesti("Tiedoston lataaminen ei onnistunut, error: " + loadSuccessfulMessage);
                }
            }

            else if (JoukkueenValinta.SelectedIndex == 3)
            {
                string loadSuccessfulMessage = Kärpät.LoadFromFile();

                if (loadSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on ladattu onnistuneesti!");
                    PäivitäNäkymä();
                }
                else
                {
                    Viesti("Tiedoston lataaminen ei onnistunut, error: " + loadSuccessfulMessage);
                }
            }
        }

        private void SaveToFile() //Metodi pelaajien tietojen tallentamiseen tiedostoon
        {
            if (JoukkueenValinta.SelectedIndex == 0)
            {
                string saveSuccessfulMessage = Jokerit.SaveToFile(); //Käytetään metodia Joukkue luokan sisältä tallentamaan pelaajatiedot tiedostoon

                if (saveSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on tallennettu tiedostoon!");
                }
                else
                {
                    Viesti("Tiedostoon tallentaminen ei onnistunut, error: " + saveSuccessfulMessage);
                }
            }

            else if (JoukkueenValinta.SelectedIndex == 1)
            {
                string saveSuccessfulMessage = TPS.SaveToFile();

                if (saveSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on tallennettu tiedostoon!");
                }
                else
                {
                    Viesti("Tiedostoon tallentaminen ei onnistunut, error: " + saveSuccessfulMessage);
                }
            }

            else if (JoukkueenValinta.SelectedIndex == 2)
            {
                string saveSuccessfulMessage = Tappara.SaveToFile();

                if (saveSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on tallennettu tiedostoon!");
                }
                else
                {
                    Viesti("Tiedostoon tallentaminen ei onnistunut, error: " + saveSuccessfulMessage);
                }
            }


            else if (JoukkueenValinta.SelectedIndex == 3)
            {
                string saveSuccessfulMessage = Kärpät.SaveToFile();

                if (saveSuccessfulMessage == "")
                {
                    Viesti("PelaajaLista on tallennettu tiedostoon!");
                }
                else
                {
                    Viesti("Tiedostoon tallentaminen ei onnistunut, error: " + saveSuccessfulMessage);
                }
            }
        }
        private void JoukkueenValinta_SelectionChanged(object sender, SelectionChangedEventArgs e) //Metodi näkymän päivitykseen kun joukkuetta vaihdetaan
        {
            PäivitäNäkymä();
        }
    }
}

