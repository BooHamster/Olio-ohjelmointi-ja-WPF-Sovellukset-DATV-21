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
namespace Harjoitus23
{
    //En kirjoittanut tätä koodia, koska minulla ei ollut aikaa, ja en vielä siinä vaiheessa tiennyt miten saada nappulan sisältö koodiin, joten olisin toteuttanut sen eri tavalla, muutin graafista ulkonäköä, ja kommentoin koodin, niin kuin sen ymmärrän
    public partial class MainWindow : Window
    {
        private Valinta valinta = Valinta.Lämpötila; //Luo enum muuttujan, ja asettaa sen sisällä olevasta kahdesta arvosta sen Lämpötila arvoon kun ohjelma käynnistetään
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumPadBtn_Click(object sender, RoutedEventArgs e) //Metodi jota käyttää kaikki kiukaan konsolin näppäimet, mikä vähentää koodin pituutta, kun jokaiselle näppäimelle ei luoda omaa metodia, mutta koodin selkeyden puolesta ei ehkä paras ratkaisu
        {
            Button buttonPressed = (Button)sender; //Luo Button muuttujan johon tallennetaan aina viimeksi painettu näppäimen sisältämä arvo, eli jos näppäimen jota painetaan content arvo on vaikka 3, se tallentuu tähän muuttujaan

            if (buttonPressed.Content.Equals("Syötä")) //Jos Syötä näppäintä painetaan se käynnistää SetValues metodin joka asettaa numPadInput kentässä olevan arvon joka lämpötilaan tai kosteuteen, riippuen kumpi on valittuna
            {
                SetValues(); //Käynnistää arvon asettamisen metodin
            }
            else if (buttonPressed.Content.Equals("<")) //Jos backspace nappulaa painetaan suoritetaan tämä else if lause
            {
                try
                {
                    numPadInput.Text = numPadInput.Text.Substring(0, numPadInput.Text.Length - 1); // Vöhentää yhden merkin numPadInput tekstikentästä

                }
                catch (Exception)
                {
                    activityMessage.Text = "Syöttökenttä on tyhjä"; //Jos numPadInput kenttä on tyhjä tämä viesti tulostuu viestikenttään
                }
            }
            else
            {
                if (numPadInput.Text.Equals("0") && buttonPressed.Content.ToString().Equals("0")) //Tämä if lause estää 0 lisäämisen, jos numPadInput syöttökentässä on jo 0 
                    return;

                if (numPadInput.Text.Equals("0")) //Tämä if lause korvaa 0:llan toisella arvolla jos numPadInput kentässä on jo 0
                {
                    numPadInput.Text = buttonPressed.Content.ToString();
                }
                else //Tämä else lause lisää jo olemassa olevaan numPadInput kentän sisältöön painettavan numeron
                {
                    numPadInput.Text += buttonPressed.Content;
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) //Radio nappulan vaihtamisen metodi, se ilmaisee käyttäjälle viestikenttään kumpaa arvoa ollaan muuttamassa
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Content.Equals("Lämpötila"))
            {
                valinta = Valinta.Lämpötila; //Vaihtaa Valinta enumeraattorin arvon Lämpötilaksi
            }
            else
            {
                valinta = Valinta.Kosteus; //Vaihtaa Valinta enumeraattorin arvon Kosteudeksi
            }

            activityMessage.Text = "Muokataan " + valinta.ToString() + " arvoja"; //Tulostaa enumeraattori arvon activityMessage viestikenttään
        }

        private void SetValues() //Metodi käyttäjän arvon asettamiseen lämpötila ja kosteus tekstikenttiin, eli temperatureField.Text ja humidityField.Text sisällön muuttamiseen, mitään varsinaisia muuttujia ei tässä ohjelmassa luoda lämpötilalle ja kosteudelle
        {
            int input = 0; //Int muuttuja jotta saadaan kokonaisluku muuttuja string tyyppisesta numPadInput kentästä

            try
            {
                input = int.Parse(numPadInput.Text); //Jäsennetään string tyyppisestä numPadInput kentän arvo kokonaisarvoon int, ja asetetaan se input int muuttujan arvoksi
            }
            catch (Exception)
            {
                activityMessage.Text = "Syöttökenttä on tyhjä"; //Jos syöttökenttä on tyhjä kun metodia suoritetaan tämä viesti tulostuu activityMessage viestikenttään
                return;
            }

            switch (valinta) //Vaihdin jossa katsotaan valinta muuttujan arvoa
            {
                case Valinta.Lämpötila: //Jos valinta muuttujan arvo on Lämpötila, niin silloin tämän casen sisältö suoritetaan
                    if (input > 120 || input < 0) //Jos input arvo on yli 120 tai ali 0:llan, niin silloin tämä if lause suoritetaan
                    {
                        activityMessage.Text = "Virheellinen lämpötila arvo annettu. Lämpötilan tulee olla 0-120 väliltä";
                        return;
                    }
                    else
                    {
                        temperatureField.Text = numPadInput.Text; //Jos arvo on 0-120 niin silloin otetaan temperatureField.Text arvo asetetaan NumPadPInput kentän arvoksi
                    }
                    break;
                case Valinta.Kosteus: //Jos valinta muuttujan arvo on Kosteus, niin silloin tämän casen sisältö suoritetaan
                    if (input > 100 || input < 0) //Jos input arvo on yli 100 tai ali 0:llan, niin silloin tämä if lause suoritetaan
                    {
                        activityMessage.Text = "Virheellinen kosteuden arvo. Kosteus tulee olla väliltä 0-100";
                        return;
                    }
                    else
                    {
                        humidityField.Text = numPadInput.Text; //Jos arvo on 0-100 niin silloin otetaan temperatureField.Text arvo asetetaan NumPadPInput kentän arvoksi
                    }
                    break;
            }

            numPadInput.Text = ""; //Viimeiseksi tyhjennetään numPadInput kentän arvo
        }
    }
}

public enum Valinta //Enumeraattori jossa on kaksi arvoa
{
    Lämpötila,
    Kosteus
}
