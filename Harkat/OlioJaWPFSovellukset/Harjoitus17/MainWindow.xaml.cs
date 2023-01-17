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
namespace Harjoitus17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Muuttujat WPF sovelluksen eri toiminnoille
        public bool OlohuoneenVal;
        public bool KeittiönVal;
        public bool OvetAuki;
        public float Lämpötila = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ovet_Click(object sender, RoutedEventArgs e) //Metodi nappulalle Ovien avaamiselle
        {
            if(!OvetAuki )
            {
                OvetAuki = true;
                OvetTeksti.Text = "Talon Ovet ovat auki";
            }
            else if (OvetAuki)
            {
                OvetAuki = false;
                OvetTeksti.Text = "Talon Ovet ovat kiinni";
            }
        }

        private void OloValot_Click(object sender, RoutedEventArgs e) //Metodi nappulalle Olohuoneen valojen hallintaan
        {
            if (!OlohuoneenVal)
            {
                OlohuoneenVal = true;
                OloHuoneenValotTeksti.Text = "Olohuoneen Valot ovat päällä";
                OloHuoneenValot1.Background = System.Windows.Media.Brushes.Yellow;
            }
        
            else if (OlohuoneenVal)
            {
                OlohuoneenVal = false;
                OloHuoneenValotTeksti.Text = "Olohuoneen Valot ovat pois päältä";
                OloHuoneenValot1.Background = System.Windows.Media.Brushes.Black;
            }
        }

        private void Laske_Click(object sender, RoutedEventArgs e) //Metodi nappulalle lämpötilan laskemiseen
        {
            Lämpötila = Lämpötila + 5;
            LämpötilaTeksti.Text = "Talon Lämpötila on " + Lämpötila + " celcius astetta";
        }

        private void Nosta_Click(object sender, RoutedEventArgs e) //Metodi nappulalle lämpötilan nostamiseen
        {
            Lämpötila = Lämpötila - 5;
            LämpötilaTeksti.Text = "Talon Lämpötila on " + Lämpötila + " celcius astetta";
        }

        private void KeittiönValot_Click(object sender, RoutedEventArgs e) //Metodi Keittiövalojen päälle ja pois laittamiseen
        {
            if (!KeittiönVal)
            {
                KeittiönVal = true;
                KeittiönValotTeksti.Text = "Keittiön Valot of päällä";
                KeittiönValot1.Background = System.Windows.Media.Brushes.Yellow;
            }

            else if (KeittiönVal)
            {
                KeittiönVal = false;
                KeittiönValotTeksti.Text = "Keittiön Valot ovat pois päältä";
                KeittiönValot1.Background = System.Windows.Media.Brushes.Black;
            }
        }
    }
}
