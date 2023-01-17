using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Harjoitus24
{
    //Lotto luokka
    public partial class Lotto
    {
        //Muuttujat, randomi numero, ja pari listaa numeroiden lisäilyä varten
        private static readonly Random Rnd = new Random();
        public static List<int> LottoLista = new List<int>();
        public static List<int> ViikonLottoLista = new List<int>();

        public static List<List<int>> LottoRivit = new List<List<int>>();
        public static List<List<int>> VoittoRivi = new List<List<int>>();
        public static string Match;

        //Metodi joka arpoo numerot lottoriville, ja lisää ne sitten listaan, yksi lottorivi on oma listansa
        public static List<int> LottoriviArpoja()
        {
            {
                var possibilites = Enumerable.Range(1, 40).ToList(); //Tämä on randomi numeron skaala listaa varten
                var ticket = new List<int>(); //Lista yhtä lottoriviä varten

                for (int i = 0; i < 7; i++) //Looppi, joka pyörii niin kauan, että ollaan lisätty niin monta riviä kuin tarvitaan yhteen lottoriviin
                {
                    var randomNumber = possibilites[Rnd.Next(possibilites.Count)]; //Määrätään tilapäiseen muuttujaan randomi numero 1-40 numeron skaalasta
                    ticket.Add(randomNumber); //Lisätään randomi numero listaan(Lottoriviin)

                    possibilites.Remove(randomNumber); //Poistetaan randomi numero joka on lisätty listaan skaalasta
                }
                ticket.Sort();
                return ticket;
            }
        }

        //Metodi Viikon lottorivin arpomiseen, ensin tyhjentää nykyisen viikon rivin, ja sitten arpoo uuden
        public static void ViikonRivi()
        {
            ViikonLottoLista.Clear();
            ViikonLottoLista = LottoriviArpoja();
        }

        //Arpoo sen määrän uusia lottorivejä kun käyttäjä on määrittänyt ohjelman sisällä tekstiboksissa
        //Metodi tyhjentää ensin Lotto Listan, ja sitten lisää siihen Lottorivin(t), käyttäen toista metodia
        public static string Arpoja()
        {
            LottoRivit.Clear();
            for (int i = 0; i < MainWindow.Rivit; i++)
            {
                LottoRivit.Add(LottoriviArpoja());

            }
            var result = string.Join(";", LottoRivit);
            return result;
        }

        //Tarkistaa monta samaa numeroa on LottoListassa verrattuna ViikonLotto Riviin, ja ilmoittaa osumien määrän ja mitkä ovat oikean numerot
        public static string Tarkistus()
        {
            Match = "";
            foreach (var ticket in LottoRivit)
            {
                var matchCount = ticket.Intersect(ViikonLottoLista).Count();
                var numerot = ticket.Intersect(ViikonLottoLista.Select(s => s));
                Match += $"Oikein osumia {matchCount} " +
                    $"tällä arvalla: {string.Join(" ", ticket)}  Numeroilla  { string.Join(" ", numerot)} \n";
            }
            return Match;
        }
        //Tyhjentää kaikki listat
        public static void Tyhjennä()
        {
            VoittoRivi.Clear();
            ViikonLottoLista.Clear();
            LottoRivit.Clear();
        }

    }
}
