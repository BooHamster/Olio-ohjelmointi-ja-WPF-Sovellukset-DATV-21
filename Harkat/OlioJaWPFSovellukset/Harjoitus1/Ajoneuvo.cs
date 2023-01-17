using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1
{
    class Ajoneuvo  //Ajoneuvo luokka
    {
        public String Nimi { get; set; } //Ajoneuvo luokan muuttujat
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public void TulostaData()       //Metodi Ajoneuvoluokan olion muuttujien tulostukseen
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Nopeus:  " + Nopeus);
            Console.WriteLine("-- Renkaat:  " + Renkaat);
        }

        public string ToString() //Toinen metodi ajoneuvo luokka olion muuttujien tietojen tulostukseen
        {
            string merkkijono = ("Ajoneuvon nimi: " + Nimi + ". Nopeus: " + Nopeus + "km/h. Renkaat: " + Renkaat + " kpl"); // asetetaan ajoneuvo luokan muuttuujat ja lisätyt tekstit yhden string muuttujen sisään

            return merkkijono;  //palauttaa string muuttujan tiedot kun metodia kutsutaan
        }

    }
}
