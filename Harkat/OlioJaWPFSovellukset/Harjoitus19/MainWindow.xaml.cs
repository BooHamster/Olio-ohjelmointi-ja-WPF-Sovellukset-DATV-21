using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
namespace Harjoitus19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Muuttujat
        public int Asetus;
        Hissi Hissi1 = new Hissi(1);
        public MainWindow()
        {
            InitializeComponent();
            KerrosNumero.Text = "" +Hissi1.Kerros;   //Tulostetaan KerrosNumeroText TextBlockiin olion Hissi1 numero
            KerrosTeksti.Text = Hissi1.ToString(); //Tulostetaan KerrosTeksti TextBoxiin Hissin1 olion tiedot ToString Metodilla
        }

        private void Ylös_Click(object sender, RoutedEventArgs e) //Metodi ylöspäin nappulalle 
        {
            if (Hissi1.Kerros == 6)
            {
                KerrosTeksti.Text = "Olet jo ylimmässä kerroksessa senkin, tollo!"; //Annetaan viesti käyttäjälle TextBoxiin jos Hissi olio on jo ylimmässä kerroksessa kun ylös nappia painetaan
            }
            else  //Jos ei olla ylimmässä versiossa, niin toteutetaan else lauseen sisältö
            {
                Hissi1.KerrosYlös();  //Hissi olio laitetaan käyttämään KerrosYlös metodia
                KerrosTeksti.Text = Hissi1.ToString();
                KerrosNumero.Text = "" + Hissi1.Kerros;
            }
        }

        private void Alas_Click(object sender, RoutedEventArgs e) //Metodi alaspäin nappulalle
        {
            if (Hissi1.Kerros == 1)
            {
                KerrosTeksti.Text = "Olet jo alimmassa kerroksessa, pahvi!";
            }
            else
            {
                Hissi1.KerrosAlas();
                KerrosTeksti.Text = Hissi1.ToString();
                KerrosNumero.Text = "" + Hissi1.Kerros;
            }
        }

        private void Aseta_Click(object sender, RoutedEventArgs e) //Metodi Alaspäin nappulalle
        {
            bool result = int.TryParse(KerrosTeksti.Text, out Asetus); //Voidaan itse antaa kerroksen numero TextBoxiin, ja Try parsella testataan onko se int tyyppinen, jos oon niin result bool antaa true arvon, jos ei niin falsen
            if (result)
            {
                if (Asetus > 6)
                {
                    Hissi1.AsetaKerros(Asetus);
                    KerrosTeksti.Text = "Hissi ei mene kuudennetta kerrosta ylemmäksi! Olet jo ylimmässä kerroksessa! "+ Hissi1.ToString();
                    KerrosNumero.Text = "" + Hissi1.Kerros;
                }
                else if (Asetus < 1)
                {
                    Hissi1.AsetaKerros(Asetus);
                    KerrosTeksti.Text = "Hissi ei mene ensimmäistä kerrosta alemmaksi! Olet jo alimmassa kerroksessa! "+ Hissi1.ToString();
                    KerrosNumero.Text = "" + Hissi1.Kerros;
                }
                Hissi1.AsetaKerros(Asetus);
                KerrosNumero.Text = "" + Hissi1.Kerros;
                KerrosTeksti.Text = Hissi1.ToString();
            }
            else if (!result) //jos käyttäjä antoi muun kuin int tyyppisen vastauksen, niin result boolean menee false arvoon, ja tämä else if lause suoritetaan
            {
                KerrosTeksti.Text = "Annoit jotain muuta kuin numeron";
            }
        }

        private void Tyhjennä_Click(object sender, RoutedEventArgs e) //Metodi tekstiruudun tyhjennykseen
        {
            KerrosTeksti.Text = "";
        }
    }
}
