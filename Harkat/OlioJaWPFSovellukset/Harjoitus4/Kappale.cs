using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Kappale //Kappale luokka
    {
        public string Nimi { get; set; } //Muuttujat
        public string Kesto { get; set; }

        public Kappale(string _nimi, string _kesto) //Konstruktori
        {
            Nimi = _nimi;
            Kesto = _kesto;
        }

        public void TulostaKappale() //Metodi tietojen tulostamiseen suoraan konsoliin
        {
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Kesto:  " + Kesto);
        }

        public string ToString() //Metodi tietojen tulostamiseen palauttamalle tiedot muuttujasta
        {
            string merkkijono = ("----Nimi:  " + Nimi + " - " + Kesto);

            return merkkijono;
        }
    }
}
