using DocumentFormat.OpenXml.Bibliography;
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
namespace Harjoitus24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Muuttujat
        public static int Rivit;
        public MainWindow()
        {

            InitializeComponent();
        }

        //Metodi Lisää Rivit nappulalle, jolla luodaan käyttäjän tekstiboksiin syöttämän määrän lottorivejä, drowndown menusta valitulle pelille, ja tulostetaan ne ikkunaan
        private void LisääRivit_Click(object sender, RoutedEventArgs e) //Metodi eri arpapelien rivien lisäämiseen
        {
            if (Valikko.SelectedIndex == 0) //Jos Lotto on valittu pudotusvalikosta
            {
                Tulos2.Text = "";
                Rivit = int.Parse(RivienMäärä.Text);
                Lotto.Arpoja();
                Tulos2.Text = "Arvotut Rivit: \n";
                foreach (List<int> Lotto in Lotto.LottoRivit)
                {
                    Tulos2.Text += String.Join(" ", Lotto);
                    Tulos2.Text += "\n";
                }
            }

            else if (Valikko.SelectedIndex == 1) // Jos VikingLotto on valittu pudotusvalikosta
            {
                Tulos2.Text = "";
                Rivit = int.Parse(RivienMäärä.Text);
                VikingLotto.Arpoja();
                Tulos2.Text = "Arvotut Rivit: \n";
                foreach (List<int> Lotto in VikingLotto.LottoRivit)
                {
                    Tulos2.Text += String.Join(" ", Lotto);
                    Tulos2.Text += "\n";
                }
            }
            else if (Valikko.SelectedIndex == 2) //Jos EuroJackPot on valittu pudotusvalikosta
            {
                Tulos2.Text = "";
                Rivit = int.Parse(RivienMäärä.Text);
                EuroJackPot.Arpoja();
                Tulos2.Text = "Arvotut Rivit: \n";
                foreach (List<int> Lotto in EuroJackPot.LottoRivit)
                {
                    Tulos2.Text += "Tähtinumerot ovat: " + String.Join(" ", Lotto[0], Lotto[1], "Päänumerot ovat: ", Lotto[2], Lotto[3], Lotto[4], Lotto[5], Lotto[6]);
                    Tulos2.Text += "\n";
                }
            }
        }
        //Metodi tekstikenttien tyhjennykseen ja eri arpapelien listojen tyhjennykseen
        private void Tyhjennä_Click(object sender, RoutedEventArgs e)
        {
            Tulos2.Text = "";
            ViikonRivitTeksti.Text = "";
            VoittoRivit.Text = "";
            Lotto.Tyhjennä();
            VikingLotto.Tyhjennä();
            EuroJackPot.Tyhjennä();
        }

        private void RivienMäärä_PreviewTextInput(object sender, TextCompositionEventArgs e) //Metodi joka tarkastaa, että tekstikenttään syötetty rivimäärä on vain numeroita, se estää muiden kuin numeroiden kirjoituksen
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ViikonRivit_Click(object sender, RoutedEventArgs e) //Metodi joka arpoo Viikon numerot valitulle arpapelille
        {
            if (Valikko.SelectedIndex == 0) //Jos Lotto on valittu pudotusvalikosta
            {
                ViikonRivitTeksti.Text = "";
                Lotto.ViikonRivi();
                ViikonRivitTeksti.Text += "Viikon Voitto Rivi: " + String.Join(" ", Lotto.ViikonLottoLista);
            }

            else if (Valikko.SelectedIndex == 1) // Jos VikingLotto on valittu pudotusvalikosta
            {
                ViikonRivitTeksti.Text = "";
                VikingLotto.ViikonRivi();
                ViikonRivitTeksti.Text += "Viikon Voitto Rivi: " + String.Join(" ", VikingLotto.ViikonLottoLista);
            }
            else if (Valikko.SelectedIndex == 2) //Jos EuroJackPot on valittu pudotusvalikosta
            {
                ViikonRivitTeksti.Text = "";
                EuroJackPot.ViikonRivi();
                ViikonRivitTeksti.Text += "Viikon Voitto Rivi: Tähtinumerot ovat: " + String.Join(" ", EuroJackPot.ViikonLottoLista[0], EuroJackPot.ViikonLottoLista[1], "Päänumerot ovat: ", EuroJackPot.ViikonLottoLista[2], EuroJackPot.ViikonLottoLista[3], EuroJackPot.ViikonLottoLista[4], EuroJackPot.ViikonLottoLista[5], EuroJackPot.ViikonLottoLista[6]);
            }
        }

        private void Voitto_Click(object sender, RoutedEventArgs e)
        {
            VoittoRivit.Text = "";
            if (Valikko.SelectedIndex == 0) //Jos Lotto on valittu pudotusvalikosta
            {
                VoittoRivit.Text = "Osumat: \n" + Lotto.Tarkistus();
            }
            else if (Valikko.SelectedIndex == 1) //Jos VikingLotto on valittu pudotusvalikosta
            {
                VoittoRivit.Text = "Osumat: \n" + VikingLotto.Tarkistus();
            }
            else if (Valikko.SelectedIndex == 2) //Jos EuroJackPot on valittu pudotusvalikosta
            {
                VoittoRivit.Text = "Osumat: \n" + EuroJackPot.Tarkistus();
            }
        }
    }
}

