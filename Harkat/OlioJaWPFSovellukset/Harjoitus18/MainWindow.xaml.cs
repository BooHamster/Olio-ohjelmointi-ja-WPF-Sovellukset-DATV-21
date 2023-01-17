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
namespace Harjoitus18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Muuttujat laskimelle
        public float ValueA;
        public float ValueB;
        public float Summa1;
        public float Erotus1;
        public float KertoLasku1;
        public float JakoLasku1;
        public MainWindow()
        {
            InitializeComponent();
            Numero1.Text = "";
            Numero2.Text = "";
        }

        private void Summa_Click(object sender, RoutedEventArgs e) //Summan laskemisen metodi
        {
            bool result = float.TryParse(Numero1.Text, out ValueA);
            bool result2 = float.TryParse(Numero2.Text, out ValueB);
            if (result && result2)
            {
                Summa1 = ValueA + ValueB;
                TulosTeksti.Text = "Tulokseksi tuli " + Summa1; //Tulostaa Tekstiruutuun kahden muuttujan summan
            }
            else if (!result2 && !result)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (!result && result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (result && !result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
        }

        private void Erotus_Click(object sender, RoutedEventArgs e) //Erotuksen metodi
        {
            bool result = float.TryParse(Numero1.Text, out ValueA);
            bool result2 = float.TryParse(Numero2.Text, out ValueB);
            if (result && result2)
            {
                Erotus1 = ValueA - ValueB;
                TulosTeksti.Text = "Tulokseksi tuli " + Erotus1;
            }
            else if (!result2 && !result)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (!result && result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (result && !result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
        }

        private void Jako_Click(object sender, RoutedEventArgs e) //Jakamisen metodi
        {
            bool result = float.TryParse(Numero1.Text, out ValueA);
            bool result2 = float.TryParse(Numero2.Text, out ValueB);
            if (result && result2)
            {
                JakoLasku1 = ValueA / ValueB;
                TulosTeksti.Text = "Tulokseksi tuli " + JakoLasku1;
            }
            else if (!result2 && !result)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (!result && result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (result && !result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
        }

        private void Kerto_Click(object sender, RoutedEventArgs e) //Kertomisen metodi
        {
            bool result = float.TryParse(Numero1.Text, out ValueA);
            bool result2 = float.TryParse(Numero2.Text, out ValueB);
            if (result && result2)
            {
                KertoLasku1 = ValueA * ValueB;
                TulosTeksti.Text = "Tulokseksi tuli " + KertoLasku1;
            }
            else if (!result2 && !result)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (!result && result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
            else if (result && !result2)
            {
                TulosTeksti.Text = "Annoit väärän arvon";
            }
        }
    }
}
