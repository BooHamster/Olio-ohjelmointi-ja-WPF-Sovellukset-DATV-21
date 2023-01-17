using System;
using System.Collections.Generic;
using System.Drawing;
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
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;
using Size = System.Drawing.Size;
//Robert Kajanti
namespace Harjoitus22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Form myform = new Form();   // Luodaan uusi ikkuna, piirrettävää ikkunaa varten
        int IkkunanLeveys = 1000;   //Luodaan piirrettävälle ikkunalla sen korkeys, leveys ja karmin leveys arvot ja asetetaan ne aluksi tiettyihin arvoihin
        int IkkunanKorkeus = 450;
        int KarminLeveys = 10;

        public MainWindow()
        {
            InitializeComponent();
            PiirräIkkuna(); //Metodi joka piirtää käyttäjän antamien arvojen kokoisen ikkunan ruutuun
        }

        private void IkkunanLeveysBox_PreviewTextInput(object sender, TextCompositionEventArgs e) //Ikkunan leveyden syöttämisen metodi
        {
            Regex regex = new Regex("[^0-9]+");  //Käytetään regex ominaisuutta siihen, että käyttäjä pystyy syöttämään pelkästään numeroita
            e.Handled = regex.IsMatch(e.Text);
        }

        private void IkkunanKorkeusBox_PreviewTextInput(object sender, TextCompositionEventArgs e) //Ikkunan korkeuden syöttämisen metodi
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void KarminLeveysBox_PreviewTextInput(object sender, TextCompositionEventArgs e) //Ikkunan karmin leveyden syöttämisen metodi
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AsetaArvot_Click(object sender, RoutedEventArgs e) // Metodi AsetaArvot nappulalle, joka piirtää käyttäjän antamien arvojen kokoisen ikkunan
        {
            if (IkkunanKorkeusBox.Text != "" && IkkunanLeveysBox.Text != "" && KarminLeveysBox.Text != "")
            {
                IkkunanLeveys = Convert.ToInt32(IkkunanLeveysBox.Text); //Otetaan muuttujille arvot tekstibokseista, ja muunnetaan ne kokonaislukuarvoihin
                IkkunanKorkeus = Convert.ToInt32(IkkunanKorkeusBox.Text);
                KarminLeveys = Convert.ToInt32(KarminLeveysBox.Text);
                myform.Size = new Size(1920, 1080); //Asetetaan Ikkunan koko johon piirrettävä ikkuna piirretään
                Graphics Ikkuna = myform.CreateGraphics();
                Brush VaaleanSininen = new SolidBrush(Color.LightGray);
                Pen Ruskea = new Pen(Color.Brown, KarminLeveys);
                Ikkuna.Clear(Color.White); //Poistetaan aiemmin piirretyt grafiikat ikkunasta
                Ikkuna.FillRectangle(VaaleanSininen, 450, 250, IkkunanLeveys, IkkunanKorkeus);
                Ikkuna.DrawRectangle(Ruskea, 450, 250, IkkunanLeveys, IkkunanKorkeus);
                myform.Show();
                IkkunanPintaAlaTeksti.Text = Convert.ToString((IkkunanLeveys + KarminLeveys) * (IkkunanKorkeus + KarminLeveys) + " cm^2");
                LasinPintaAlaTeksti.Text = Convert.ToString(IkkunanLeveys * IkkunanKorkeus + " cm^2");
                KarminPiiriTeksti.Text = Convert.ToString((IkkunanLeveys + KarminLeveys + IkkunanKorkeus + KarminLeveys) * 2 + " cm");
            }
        }

        public void PiirräIkkuna() // Metodi joka piirtää ohjelman alussa tietyn kokoisen ikkunan, jotta käyttäjä näkee esimerkin
        {
            myform.Size = new Size(1920, 1080);                         //Asetetaan Ikkunan koko johon piirrettävä ikkuna piirretään
            myform.FormBorderStyle = FormBorderStyle.FixedDialog;
            myform.StartPosition = FormStartPosition.CenterScreen;      //Mihin kohtaa näyttöä piirretään ikkuna
            Graphics Ikkuna = myform.CreateGraphics();                  //Otetaan "piirtäminen" käyttöön ikkunalle
            myform.Show();                                              //Grafiikan piirtämisen komento
            Brush VaaleanSininen = new SolidBrush(Color.LightGray);     //Määritetään uusi sivellin muuttuja ja sen väri
            Pen Ruskea = new Pen(Color.Brown, KarminLeveys);            //Määritetään uusi kynä muuttuja ja sen väri, ja sen leveys
            Ikkuna.FillRectangle(VaaleanSininen, 450, 250, IkkunanLeveys, IkkunanKorkeus); //Piirretään ikkunanlasi ja täytetään se vaaleansinisellä
            Ikkuna.DrawRectangle(Ruskea, 450, 250, IkkunanLeveys, IkkunanKorkeus); //Piirretään karmi
            if (IkkunanPintaAlaTeksti != null && LasinPintaAlaTeksti != null && KarminPiiriTeksti != null)
            {
                IkkunanPintaAlaTeksti.Text = Convert.ToString((IkkunanLeveys + KarminLeveys) * (IkkunanKorkeus + KarminLeveys) + " cm^2"); //Lasketaan ikkunanpinta-ala annetusta arvosta
                LasinPintaAlaTeksti.Text = Convert.ToString(IkkunanLeveys * IkkunanKorkeus + " cm^2"); //Lasketaan ikkunan lasin pinta-ala annetusta arvosta
                KarminPiiriTeksti.Text = Convert.ToString((IkkunanLeveys + KarminLeveys + IkkunanKorkeus + KarminLeveys) * 2 + " cm"); //Lasketaan karmin piiri annetusta arvosta
            }
        }

    }
}

