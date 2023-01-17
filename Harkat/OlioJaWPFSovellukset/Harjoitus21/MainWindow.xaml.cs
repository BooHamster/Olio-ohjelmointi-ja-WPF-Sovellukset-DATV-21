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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Robert Kajanti
namespace Harjoitus21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tuotteet.LisääTuotteet();
            TuoteListaGrid.ItemsSource = Tuotteet.NäytäTuotteet(); //Tuo Metodin tulostamat tiedot DataGridiin
        }

        private void Siirrä_Click(object sender, RoutedEventArgs e) //Metodi tuotteiden siirtämiseen Tuotelistasta Ostoskoriin
        {
            foreach (Tuote tuote in TuoteListaGrid.ItemsSource)
            {
                if (tuote.Valittuna)
                {
                    Tuotteet.Lisää(tuote);
                    tuote.Valittuna = false;
                    Viestit.Text = "Valitut tuotteet siirretty Ostoskärryyn";
                }
            }
            OstosLista_Grid.ItemsSource = null;
            TuoteListaGrid.ItemsSource = Tuotteet.NäytäTuotteet();
            OstosLista_Grid.ItemsSource = Tuotteet.NäytäTuotteet2();

        }

        private void Poista_Click(object sender, RoutedEventArgs e) //Poistaa valitut tuotteet ostoskorista
        {
            foreach (Tuote tuote in OstosLista_Grid.ItemsSource)
            {
                if (tuote.Valittuna)
                {
                    Tuotteet.Ostokset.Remove(tuote);              
                }
            }
            Viestit.Text = "Valitut tuotteet poistettu";
            OstosLista_Grid.ItemsSource = Tuotteet.NäytäTuotteet2();
        }

        private void Osta_Click(object sender, RoutedEventArgs e) //Ostaa ostoskorista valitut tuotteet
        {
            foreach (Tuote tuote in OstosLista_Grid.ItemsSource)
            {
                if (tuote.Valittuna)
                {
                    Tuotteet.Ostokset.Remove(tuote);
                    Viestit.Text = "Valitut tuotteet Ostettu";
                    Tuotteet.KokonaisHinta = 0;
                    Summa.Text = "" + Tuotteet.Laske(tuote);
                }
            }
            OstosLista_Grid.ItemsSource = Tuotteet.NäytäTuotteet2();
        }
    }
}
