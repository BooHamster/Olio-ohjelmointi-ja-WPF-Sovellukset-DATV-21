using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Katso Lotto luokan kommentit, muuten sama koodi, paitsi kaksi tähtinumeroa EuroJackpotissa on 1-12, ja viisi päänumeroa 1-50.
namespace Harjoitus24
{
    class EuroJackPot
    {
        private static readonly Random Rnd = new Random();
        public static List<int> LottoLista = new List<int>();
        public static List<int> ViikonLottoLista = new List<int>();

        public static List<List<int>> LottoRivit = new List<List<int>>();
        public static List<List<int>> VoittoRivi = new List<List<int>>();
        public static string Match;

        public static List<int> LottoriviArpoja()
        {
            {
                var possibilites = Enumerable.Range(1, 50).ToList();
                var possibilites2 = Enumerable.Range(1, 12).ToList();
                var ticket = new List<int>();

                for (int i = 0; i < 5; i++)
                {
                    var randomNumber = possibilites[Rnd.Next(possibilites.Count)];
                    ticket.Add(randomNumber);

                    possibilites.Remove(randomNumber);
                }

                for (int i = 0; i < 2; i++)
                {
                    var randomNumber = possibilites2[Rnd.Next(possibilites2.Count)];
                    ticket.Add(randomNumber);

                    possibilites2.Remove(randomNumber);
                }

                ticket.Sort();
                return ticket;
            }
        }


        public static void ViikonRivi()
        {
            ViikonLottoLista.Clear();
            ViikonLottoLista = LottoriviArpoja();
        }
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

        public static void Tyhjennä()
        {
            VoittoRivi.Clear();
            ViikonLottoLista.Clear();
            LottoRivit.Clear();
        }
    }
}
