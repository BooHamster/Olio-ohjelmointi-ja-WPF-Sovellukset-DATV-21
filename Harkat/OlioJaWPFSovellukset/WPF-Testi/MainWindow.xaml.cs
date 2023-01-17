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
namespace WPF_Testi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int henkilöAuto = 0; //Luodaan henkilöauto muuttuja, ja asetetaan se 0 arvoon
        public int kuormaAuto = 0; //Luodaan kuormaauto muuttuja, ja asetetaan se 0 arvoon
        public  MainWindow()
        {
            InitializeComponent();
            tbinfo_henk.Text = ""; //Muokkaa tbinfo_henk TextBoxin tekstiä, tämä tyhjentää sen
            tbinfo_kuorma.Text = ""; //Muokkaa tbinfo_kuorma TextBoxin tekstiä, tämä tyhjentää sen
          
        }

        //Kun painetaan salamaa, se luo Event Handlerin(koodin napin painallukselle), sille napille(buttonille)

        private void btnikuorma_click(object sender, RoutedEventArgs e)
        {
            kuormaAuto++; //Lisätään aina yksi kuormaAuto muuttujaan kun nappia painetaan
            tbinfo_kuorma.Text = "KuormaAutoja on mennyt ohi " + kuormaAuto + " kappaletta";
        }

        private void btnhenkauto_click(object sender, RoutedEventArgs e)
        {
            henkilöAuto++; //Lisätään aina yksi henkilöAuto muuttujaan kun nappia painetaan
            tbinfo_henk.Text = "Henkilöautoja on mennyt ohi " + henkilöAuto + " kappaletta";
        }
    }
}
