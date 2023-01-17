using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus21
{
    class Tuotteet //Tuotteet luokka
    {
        //Muuttujat
        public static decimal KokonaisHinta;
        public static Dictionary<string, Tuote> Tuotteet2 = new Dictionary<string, Tuote>();
        public static List<Tuote> Ostokset = new List<Tuote>();

        public static void LisääTuotteet() //Metodi Tuotteiden lisäämiseen Tuotteet2 kokoelmaan
        {
            Tuotteet2.Add("Makkara", new Tuote("Makkara", 3.99M));
            Tuotteet2.Add("Peruna", new Tuote("Peruna", 1.50M));
            Tuotteet2.Add("Maman Chicken Noodeli", new Tuote("Maman Chicken Noodeli", 4.99M));
            Tuotteet2.Add("Norjalainen Lohi", new Tuote("Norjalainen Lohi", 18.99M));
            Tuotteet2.Add("Munakoiso", new Tuote("Munakoiso", 1.99M));
            Tuotteet2.Add("Kurkku", new Tuote("Kurkku", 5.99M));
            Tuotteet2.Add("Riisi", new Tuote("Riisi", 3.50M));
            Tuotteet2.Add("Appelsiini", new Tuote("Appelsiini", 6.50M));
        }
        public static List<Tuote> NäytäTuotteet() //Metodi tuotteiden näyttämiseen Tuotelista gridiin
        {
            {
                List<Tuote> Tuotteet1 = new List<Tuote>();
                Tuotteet1.AddRange(Tuotteet2.Values);
                return Tuotteet1;
            }
        }
        public static List<Tuote> NäytäTuotteet2() //Metodi tuotteiden näyttämiseen Ostoskori gridiin
        {
            {
                List<Tuote> Ostokset2 = new List<Tuote>();
                Ostokset2.AddRange(Ostokset);
                return Ostokset2;
            }
        }
        public static void Lisää(Tuote tuote) //Metodi tuotteen lisääminen Ostoskoriin
        {
            Ostokset.Add(tuote);
        }
        public static void Poista(Tuote tuote) //Metodi tuotteen poistamiseen Ostoskorista
        {
            Ostokset.Remove(tuote);
        }
        public static decimal Laske(Tuote tuote) //Metodi kaikkien tuotteiden hintojen summan laskuun
        {
            KokonaisHinta = KokonaisHinta + tuote.Hinta;
            return KokonaisHinta;
        }
    }
}
