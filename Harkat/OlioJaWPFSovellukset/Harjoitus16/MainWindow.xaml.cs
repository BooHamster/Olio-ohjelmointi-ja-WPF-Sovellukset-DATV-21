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
namespace Harjoitus16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public float kilometri;
       public float maili;

        public MainWindow()
        {
            InitializeComponent();
            Kilometrit.Text = ""; //Muokkaa tbinfo_henk TextBoxin tekstiä, tämä tyhjentää sen
            Mailit.Text = ""; //Muokkaa tbinfo_kuorma TextBoxin tekstiä, tämä tyhjentää sen
        }

        public void Käännä_click(object sender, RoutedEventArgs e)
        {
            bool result = float.TryParse(Kilometrit.Text, out kilometri);
            bool result2 = float.TryParse(Mailit.Text, out maili);
            float mailit = MilesToKm(maili);
            float kilometrit = KmToMiles(kilometri);
            if (result && result2)
            {
                Kilometrit.Text = kilometri + " Kilometriä on " + kilometrit + " Mailia";
                Mailit.Text = maili + " Mailia on " + mailit + " Kilometriä";
            }
            else if(!result2 && !result)               
            {
                Kilometrit.Text = "Annoit väärän arvon";
                Mailit.Text = "Annoit väärän arvon";
            }
            else if (!result && result2)
            {
                Mailit.Text = maili + " Mailia on " + mailit + " Kilometriä";
                Kilometrit.Text = "Annoit väärän arvon";
            }
            else if (result && !result2)
            {
                Kilometrit.Text = kilometri + " Kilometriä on " + kilometrit + " Mailia";
                Mailit.Text = "Annoit väärän arvon";
            }          
        }

        public static float KmToMiles(float i) //Metodi kilometrien muuttamiseen maileihin
        {
            float conversion = 0.62137f;
            return i * conversion;
        }

        public static float MilesToKm(float i) //Metodi mailien muuttamiseen kilometreihin
        {
            float conversion = 1.609f;
            return i * conversion;
        }

        private void TyhjennäClick(object sender, RoutedEventArgs e)
        {
            Kilometrit.Text = ""; //Muokkaa tbinfo_henk TextBoxin tekstiä, tämä tyhjentää sen
            Mailit.Text = ""; //Muokkaa tbinfo_kuorma TextBoxin tekstiä, tämä tyhjentää sen
        }
    }
}
